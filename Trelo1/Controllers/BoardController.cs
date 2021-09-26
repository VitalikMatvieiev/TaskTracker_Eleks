﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trelo1.Interfaces;
using Trelo1.Models;

namespace Trelo1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BoardController : ControllerBase
    {
        private readonly IBoardService _boardService;
        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }

        [HttpPost]
        public IActionResult CreateBoard(Board board)
        {
            if (board != null)
            {
                _boardService.CreateBoard(board);
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public IActionResult AddUserToBoard(int userId, int boardId)
        {
            _boardService.AddUserToBoard(userId, boardId);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBoard(int boardId)
        {
            _boardService.DeleteBoard(boardId);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteUserFromBoard(int userId, int boardId)
        {
            _boardService.DeleteUserFromBoard(userId, boardId);
            return Ok();
        }
    }
}
