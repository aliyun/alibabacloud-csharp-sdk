// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class PageQueryAgentListNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied detail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Access denied due to insufficient permissions</para>
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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQueryAgentListNewResponseBodyData Data { get; set; }
        public class PageQueryAgentListNewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<PageQueryAgentListNewResponseBodyDataList> List { get; set; }
            public class PageQueryAgentListNewResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <para>The agent creation mode. Valid values:<br>
                /// <c>0</c>: Prompt mode (<c>PROMPT</c>). <c>1</c>: Conversation flow mode (<c>CONVERSATION</c>).<br></para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AgentMode")]
                [Validation(Required=false)]
                public long? AgentMode { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>智能客服助手</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>The application code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aicc_demo_app</para>
                /// </summary>
                [NameInMap("ApplicationCode")]
                [Validation(Required=false)]
                public string ApplicationCode { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The deployment branch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("DeployBranchId")]
                [Validation(Required=false)]
                public long? DeployBranchId { get; set; }

                /// <summary>
                /// <para>The effective branch name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("DeployBranchName")]
                [Validation(Required=false)]
                public string DeployBranchName { get; set; }

                /// <summary>
                /// <para>The agent description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>智能客服助手，提供自动化的客户服务支持</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The effective version ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("EffectiveVersionId")]
                [Validation(Required=false)]
                public long? EffectiveVersionId { get; set; }

                /// <summary>
                /// <para>The effective version name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("EffectiveVersionName")]
                [Validation(Required=false)]
                public string EffectiveVersionName { get; set; }

                /// <summary>
                /// <para>Specifies whether the agent can be used for outbound calls. A value of <c>true</c> means the agent\&quot;s current deployment branch has a published version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                /// <summary>
                /// <para>The most recent publish time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("LatestPublishTime")]
                [Validation(Required=false)]
                public string LatestPublishTime { get; set; }

                /// <summary>
                /// <para>The last modified time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-15 10:30:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The scene.</para>
                /// 
                /// <b>Example:</b>
                /// <para>个人线索转化</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The message that describes the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789012</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b><c>true</c></b>: The request succeeded.</para>
        /// </description></item>
        /// <item><description><para><b><c>false</c></b>: The request failed.</para>
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
