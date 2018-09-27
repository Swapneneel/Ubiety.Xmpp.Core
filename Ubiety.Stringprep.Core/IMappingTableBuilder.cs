﻿using System.Collections.Generic;

namespace Ubiety.Stringprep.Core
{
    public interface IMappingTableBuilder
    {
        IMappingTableBuilder WithValueRangeTable(int[] values, int replacement);

        IMappingTableBuilder WithValueRangeTable(int[] values, int[] replacement);

        IMappingTableBuilder WithMappingTable(IDictionary<int, int[]> table);

        IMappingTableBuilder Include(IDictionary<int, int[]> include);

        IMappingTableBuilder Remove(int remove);

        IMappingTable Compile();
    }
}