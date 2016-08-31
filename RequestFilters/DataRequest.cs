﻿namespace RequestFilters
{
    using System.Collections.Generic;
    
    /// <summary>
    /// Container for filters.
    /// </summary>
    public class DataRequest
    {
        /// <summary>
        /// Where filters.
        /// </summary>
        public TreeFilter Where { get; set; }

        /// <summary>
        /// Order filters.
        /// </summary>
        public List<OrderFilter> OrderBy { get; set; }

        /// <summary>
        /// Skip number of elements.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Take number of elements.
        /// </summary>
        public int Take { get; set; }
    }
}