﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Core.Dto_s.Items;
using Workshop.Core.Models;

namespace Workshop.Core.Interfaces
{
    public interface IItemsRepository
    {
        Task<PagedResponse> GetItemsAsync(int PageIndex, int PageSize);
        Task<PagedResponse> PaginationAsync(IQueryable<ItemsDto> Quary, int PageIndex, int PageSize);

    }
}
