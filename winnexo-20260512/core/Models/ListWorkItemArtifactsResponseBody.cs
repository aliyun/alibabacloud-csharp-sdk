// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkItemArtifactsResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>历史产物列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkItemArtifactsResponseBodyItems> Items { get; set; }
        public class ListWorkItemArtifactsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>产物ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("artifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>产物键</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("artifactKey")]
            [Validation(Required=false)]
            public string ArtifactKey { get; set; }

            /// <summary>
            /// <para>节点尝试序号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attemptSeq")]
            [Validation(Required=false)]
            public long? AttemptSeq { get; set; }

            /// <summary>
            /// <para>内容类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>创建时间(ISO8601)</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>节点键</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("nodeKey")]
            [Validation(Required=false)]
            public string NodeKey { get; set; }

            /// <summary>
            /// <para>计划ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>引用信息</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ref")]
            [Validation(Required=false)]
            public ListWorkItemArtifactsResponseBodyItemsRef Ref { get; set; }
            public class ListWorkItemArtifactsResponseBodyItemsRef : TeaModel {
                /// <summary>
                /// <para>产物ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>引用类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>WORK_ITEM_ARTIFACT</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>OpenAPI 产物访问入口</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>运行ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>内容SHA-256</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>产物大小(字节)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>产物摘要</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>产物标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>会话轮次序号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("turnSeq")]
            [Validation(Required=false)]
            public long? TurnSeq { get; set; }

            /// <summary>
            /// <para>产物类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>工作项ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

        }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>返回产物数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
