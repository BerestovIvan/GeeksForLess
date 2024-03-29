﻿using AutoMapper;
using BLL.Models;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using GeeksForLess.Models.PostModels;
using GeeksForLess.Models.PutModels;
using GeeksForLess.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeeksForLess.Controllers
{
    [Route("[controller]")]
    public class TopicController : Controller
    {
        private readonly ITopicService topicService;
        private readonly IMapper mapper;

        public TopicController(ITopicService topicService, IMapper mapper)
        {
            this.topicService = topicService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TopicViewModel>>> Get()
        {
            var topicViewModels = await topicService.Get();
            return Ok(mapper.Map<IEnumerable<TopicViewModel>>(topicViewModels));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TopicViewModel>>> Get(Guid id)
        {
            var topicViewModels = await topicService.Get(id);
            return Ok(mapper.Map<TopicViewModel>(topicViewModels));
        }

        [HttpPost("Create")]
        public async Task<ActionResult<TopicPostModel>> Create([FromBody] TopicPostModel topicPostModel)
        {
            var topic = mapper.Map<TopicModel>(topicPostModel);
            topic = await topicService.Create(topic);
            topicPostModel = mapper.Map<TopicPostModel>(topic);
            return Created("~/api/topic/" + topicPostModel.Id, topicPostModel);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await topicService.Delete(id);
            return Ok();
        }

        [HttpPut("Update")]
        public async Task<ActionResult<TopicPutModel>> Update([FromBody] TopicPutModel topicPutModel)
        {
            var topic = mapper.Map<TopicModel>(topicPutModel);
            topic = await topicService.Update(topic);
            topicPutModel = mapper.Map<TopicPutModel>(topic);
            return Ok(topicPutModel);

        }
    }
}
