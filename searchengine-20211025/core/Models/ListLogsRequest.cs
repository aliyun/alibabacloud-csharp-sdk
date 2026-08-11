// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListLogsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. This is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710432000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The search statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 200 AND totalTime &gt; 0.01</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. This is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1706340600</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The log type. Valid values: \<c>select\\</c> (query logs) and \<c>push\\</c> (write logs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>push</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
