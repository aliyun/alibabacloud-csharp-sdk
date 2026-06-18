// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Job list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskListResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Indicates whether there is a next page. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            /// <summary>
            /// <para>Job information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskListResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Concurrent outbound calls.</para>
                /// <remarks>
                /// <para>Parameter specific to auto dialing.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConcurrentRate")]
                [Validation(Required=false)]
                public int? ConcurrentRate { get; set; }

                /// <summary>
                /// <para>The deadline for job creation. UNIX timestamp format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1615083365000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Job description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>房产销售</para>
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
                /// <para>Job completion rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                /// <summary>
                /// <para>Skill group ID (for predictive dialing) or IVR ID (for auto dialing).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2468****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public long? HandlerId { get; set; }

                /// <summary>
                /// <para>Skill group name or IVR name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>热线技能组</para>
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// <para>Job name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx外呼任务</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Task Status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Not started.</description></item>
                /// <item><description><b>1</b>: In progress.</description></item>
                /// <item><description><b>2</b>: System paused.</description></item>
                /// <item><description><b>3</b>: Manually paused.</description></item>
                /// <item><description><b>4</b>: Completed.</description></item>
                /// <item><description><b>5</b>: Stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>Task status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>未开始</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>Job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1763****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>Total number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
