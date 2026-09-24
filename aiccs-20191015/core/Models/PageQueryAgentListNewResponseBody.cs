// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class PageQueryAgentListNewResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
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
        /// <para>The returned data.</para>
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
                /// <para>The agent building mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: prompt mode (PROMPT).</description></item>
                /// <item><description>1: dialog flow mode (CONVERSATION).</description></item>
                /// </list>
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
                /// <para>Intelligent Customer Service Assistant</para>
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
                /// <para>The creation time, in the format of YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the branch being deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("DeployBranchId")]
                [Validation(Required=false)]
                public long? DeployBranchId { get; set; }

                /// <summary>
                /// <para>The name of the active branch.</para>
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
                /// <para>Intelligent customer service assistant that provides automated customer service support</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the active version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("EffectiveVersionId")]
                [Validation(Required=false)]
                public long? EffectiveVersionId { get; set; }

                /// <summary>
                /// <para>The name of the active version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("EffectiveVersionName")]
                [Validation(Required=false)]
                public string EffectiveVersionName { get; set; }

                /// <summary>
                /// <para>Indicates whether the agent is available for outbound calls. A value of True indicates that the current deployment branch of the agent has a published version and is available for outbound calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                /// <summary>
                /// <para>The latest version publish time, in the format of YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("LatestPublishTime")]
                [Validation(Required=false)]
                public string LatestPublishTime { get; set; }

                /// <summary>
                /// <para>The last modification time, in the format of YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-15 10:30:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The scenario.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal lead conversion</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The service direction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("ServiceDirection")]
                [Validation(Required=false)]
                public string ServiceDirection { get; set; }

                /// <summary>
                /// <para>The source template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>62</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

                /// <summary>
                /// <para>The source template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sample value</para>
                /// </summary>
                [NameInMap("TemplateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
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
        /// <para>Indicates whether the API call was successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
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
