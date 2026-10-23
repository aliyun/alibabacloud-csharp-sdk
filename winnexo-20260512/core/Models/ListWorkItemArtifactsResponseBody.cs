// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkItemArtifactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of historical artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkItemArtifactsResponseBodyItems> Items { get; set; }
        public class ListWorkItemArtifactsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The artifact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("artifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The artifact key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("artifactKey")]
            [Validation(Required=false)]
            public string ArtifactKey { get; set; }

            /// <summary>
            /// <para>The node attempt sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attemptSeq")]
            [Validation(Required=false)]
            public long? AttemptSeq { get; set; }

            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The creation time in ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The node key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("nodeKey")]
            [Validation(Required=false)]
            public string NodeKey { get; set; }

            /// <summary>
            /// <para>The plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The reference information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ref")]
            [Validation(Required=false)]
            public ListWorkItemArtifactsResponseBodyItemsRef Ref { get; set; }
            public class ListWorkItemArtifactsResponseBodyItemsRef : TeaModel {
                /// <summary>
                /// <para>The artifact ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The reference data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WORK_ITEM_ARTIFACT</para>
                /// </summary>
                [NameInMap("kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The OpenAPI artifact access endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example</para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The run ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>The SHA-256 hash of the content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("sha256")]
            [Validation(Required=false)]
            public string Sha256 { get; set; }

            /// <summary>
            /// <para>The artifact size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sizeBytes")]
            [Validation(Required=false)]
            public long? SizeBytes { get; set; }

            /// <summary>
            /// <para>The artifact summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The artifact title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The session turn sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("turnSeq")]
            [Validation(Required=false)]
            public long? TurnSeq { get; set; }

            /// <summary>
            /// <para>The artifact type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The work item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned artifacts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
