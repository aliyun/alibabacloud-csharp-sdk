// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskListResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskListResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskListResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConcurrentRate")]
                [Validation(Required=false)]
                public int? ConcurrentRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1615083365000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>70</para>
                /// </summary>
                [NameInMap("FinishCount")]
                [Validation(Required=false)]
                public int? FinishCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.7</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2468****</para>
                /// </summary>
                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public long? HandlerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>热线技能组</para>
                /// </summary>
                [NameInMap("HandlerName")]
                [Validation(Required=false)]
                public string HandlerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx外呼任务</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>未开始</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1763****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
