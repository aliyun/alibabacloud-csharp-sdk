// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeConfigGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration group information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeConfigGroupResponseBodyData> Data { get; set; }
        public class DescribeConfigGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of resources bound to the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>The quantity information of resources bound to the configuration group.</para>
            /// </summary>
            [NameInMap("BindCountMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> BindCountMap { get; set; }

            /// <summary>
            /// <para>The description of the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task information</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The configuration group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccg-0cid8v30an12****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>Used for frontend display. The code for the system scheduled task description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE_DESC</para>
            /// </summary>
            [NameInMap("InnerTimerDesc")]
            [Validation(Required=false)]
            public string InnerTimerDesc { get; set; }

            /// <summary>
            /// <para>Used for frontend display. The mapping code for the system scheduled task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INNER_TIMER_10_MINUTES_HIBERNATE_NO_UPDATE</para>
            /// </summary>
            [NameInMap("InnerTimerName")]
            [Validation(Required=false)]
            public string InnerTimerName { get; set; }

            /// <summary>
            /// <para>Used by system scheduled task check. The current scheduled task does not support unbinding or binding.</para>
            /// </summary>
            [NameInMap("IsBind")]
            [Validation(Required=false)]
            public bool? IsBind { get; set; }

            /// <summary>
            /// <para>Used by system scheduled task check. The current scheduled task does not support modification.</para>
            /// </summary>
            [NameInMap("IsUpdate")]
            [Validation(Required=false)]
            public bool? IsUpdate { get; set; }

            /// <summary>
            /// <para>The configuration group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled task</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The product type used by the configuration group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The configuration group status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The configuration group type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Timer</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
