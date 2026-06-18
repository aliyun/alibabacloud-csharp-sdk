// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class PageQueryAgentListResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed reason for the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access Denied</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQueryAgentListResponseBodyData Data { get; set; }
        public class PageQueryAgentListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of agents.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<PageQueryAgentListResponseBodyDataList> List { get; set; }
            public class PageQueryAgentListResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121312*******</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试智能体</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>The application code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DFAS*****</para>
                /// </summary>
                [NameInMap("ApplicationCode")]
                [Validation(Required=false)]
                public string ApplicationCode { get; set; }

                /// <summary>
                /// <para>The reason for the review failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>请补充流程说明</para>
                /// </summary>
                [NameInMap("AuditReason")]
                [Validation(Required=false)]
                public string AuditReason { get; set; }

                /// <summary>
                /// <para>The reason for the build failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>系统错误</para>
                /// </summary>
                [NameInMap("BuildFailReason")]
                [Validation(Required=false)]
                public string BuildFailReason { get; set; }

                /// <summary>
                /// <para>The business scenario name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人客户线索转化</para>
                /// </summary>
                [NameInMap("BusinessTypeName")]
                [Validation(Required=false)]
                public string BusinessTypeName { get; set; }

                /// <summary>
                /// <para>The time the agent was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-28 17:10:17</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The agent description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用于日常测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time the agent was last online.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-28 14:38:15</para>
                /// </summary>
                [NameInMap("LastOnlineTime")]
                [Validation(Required=false)]
                public string LastOnlineTime { get; set; }

                /// <summary>
                /// <para>The time the agent was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-10-28 17:10:17</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The agent status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("WithActivePrompt")]
                [Validation(Required=false)]
                public bool? WithActivePrompt { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent has been configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("WithConfig")]
                [Validation(Required=false)]
                public bool? WithConfig { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total count of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>742C9243-2870-B8D6-0C68-C60BEB2DF09A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
