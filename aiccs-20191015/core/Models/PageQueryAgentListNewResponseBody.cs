// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class PageQueryAgentListNewResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Access denied due to insufficient permissions</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PageQueryAgentListNewResponseBodyData Data { get; set; }
        public class PageQueryAgentListNewResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<PageQueryAgentListNewResponseBodyDataList> List { get; set; }
            public class PageQueryAgentListNewResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AgentMode")]
                [Validation(Required=false)]
                public long? AgentMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>aicc_demo_app</para>
                /// </summary>
                [NameInMap("ApplicationCode")]
                [Validation(Required=false)]
                public string ApplicationCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("DeployBranchId")]
                [Validation(Required=false)]
                public long? DeployBranchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>master</para>
                /// </summary>
                [NameInMap("DeployBranchName")]
                [Validation(Required=false)]
                public string DeployBranchName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("EffectiveVersionId")]
                [Validation(Required=false)]
                public long? EffectiveVersionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("EffectiveVersionName")]
                [Validation(Required=false)]
                public string EffectiveVersionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-20 12:00:00</para>
                /// </summary>
                [NameInMap("LatestPublishTime")]
                [Validation(Required=false)]
                public string LatestPublishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-15 10:30:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>28</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>41</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789012</para>
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

    }

}
