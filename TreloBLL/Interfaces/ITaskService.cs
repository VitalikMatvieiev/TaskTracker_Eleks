﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreloBLL.DtoModel;
using TreloDAL.Models;

namespace Trelo1.Interfaces
{
    public interface ITaskService
    {
        Task Create(TaskDto userTask, IList<IFormFile> formFiles, int? taskId);
        Task<bool> Delete(int id);
        Task AssignUserToTask(int taskId, int userId);
        Task<TaskDto> GetTask(int taskId);
        Task<IEnumerable<TaskDto>> GetUserTasks(int userId);
        Task<IEnumerable<TaskDto>> GetBoardTasks(int boardId);
        IEnumerable<TaskDto> GetOrganizationTasks(int organizationId);
        Task<string> GetTaskChangeLogs(int taskId);
        //Task AssigneFileToTask(IList<IFormFile> formFiles, int taskId);

    }
}
