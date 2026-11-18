// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListExecutorEventsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for querying executors.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListExecutorEventsRequestFilter Filter { get; set; }
        public class ListExecutorEventsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The list of executor IDs. You can specify up to 100 IDs.</para>
            /// </summary>
            [NameInMap("ExecutorIds")]
            [Validation(Required=false)]
            public List<string> ExecutorIds { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The level of the runtime event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Warning</description></item>
            /// <item><description>Error</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The start time of the events. Events that occur after this time are returned. The time must be a UNIX timestamp based on the time zone of the region (UTC+8 for the Chinese site).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeAfter")]
            [Validation(Required=false)]
            public long? TimeAfter { get; set; }

            /// <summary>
            /// <para>The end time of the events. Events that occur before this time are returned. The time must be a UNIX timestamp based on the time zone of the region (UTC+8 for the Chinese site).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeBefore")]
            [Validation(Required=false)]
            public long? TimeBefore { get; set; }

        }

        /// <summary>
        /// <para>The page number. Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
