// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskListResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Indicates whether a next page exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            /// <summary>
            /// <para>The task information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskListResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The outbound call concurrency.</para>
                /// <remarks>
                /// <para>This parameter is specific to automatic outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConcurrentRate")]
                [Validation(Required=false)]
                public int? ConcurrentRate { get; set; }

                /// <summary>
                /// <para>The end time for task creation. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615083365000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The task description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Real estate sales</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The number of completed tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("FinishCount")]
                [Validation(Required=false)]
                public int? FinishCount { get; set; }

                /// <summary>
                /// <para>The task completion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                /// <summary>
                /// <para>The skill group ID for predictive outbound calls or the IVR ID for automatic outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2468****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public long? HandlerId { get; set; }

                /// <summary>
                /// <para>The skill group name or IVR name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hotline skill group</para>
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx outbound call task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: not started</description></item>
                /// <item><description><b>1</b>: in progress</description></item>
                /// <item><description><b>2</b>: paused by the system</description></item>
                /// <item><description><b>3</b>: paused manually</description></item>
                /// <item><description><b>4</b>: completed</description></item>
                /// <item><description><b>5</b>: terminated</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The task status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Not started</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1763****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The total number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: successful</description></item>
        /// <item><description><b>false</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
