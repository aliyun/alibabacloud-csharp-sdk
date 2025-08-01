// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiLLMTrace20240311.Models
{
    public class ListOnlineEvalTasksRequest : TeaModel {
        /// <summary>
        /// <para>Search keyword. It will match on fields such as task name, application name (appName), task description, and evaluation metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The UTC end time of the search time range</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-07 13:24:25
        /// 2025-04-07</para>
        /// </summary>
        [NameInMap("MaxTime")]
        [Validation(Required=false)]
        public string MaxTime { get; set; }

        /// <summary>
        /// <para>The UTC start time of the search time range</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-04-05 13:24:25
        /// 2025-04-05</para>
        /// </summary>
        [NameInMap("MinTime")]
        [Validation(Required=false)]
        public string MinTime { get; set; }

        /// <summary>
        /// <para>The current page number. Value range: integers greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
