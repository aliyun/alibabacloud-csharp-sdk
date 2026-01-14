// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class AgentGroupPageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public AgentGroupPageResponseBodyModel Model { get; set; }
        public class AgentGroupPageResponseBodyModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>62</para>
            /// </summary>
            [NameInMap("Current")]
            [Validation(Required=false)]
            public long? Current { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>82</para>
            /// </summary>
            [NameInMap("Pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<AgentGroupPageResponseBodyModelRecords> Records { get; set; }
            public class AgentGroupPageResponseBodyModelRecords : TeaModel {
                /// <summary>
                /// <para>坐席组ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentGroupId")]
                [Validation(Required=false)]
                public long? AgentGroupId { get; set; }

                /// <summary>
                /// <para>坐席组名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("AgentGroupName")]
                [Validation(Required=false)]
                public string AgentGroupName { get; set; }

                /// <summary>
                /// <para>坐席组下的坐席id列表</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public List<long?> AgentIds { get; set; }

                /// <summary>
                /// <para>创建坐席组的时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01 11:11:11</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>71</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
