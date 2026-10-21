// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateImageCacheResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of creating the image cache.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateImageCacheResponseBodyData Data { get; set; }
        public class CreateImageCacheResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the source ACR Enterprise instance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-example</para>
            /// </summary>
            [NameInMap("acrInstanceId")]
            [Validation(Required=false)]
            public string AcrInstanceId { get; set; }

            /// <summary>
            /// <para>The deduplicated number of agents that have useImageCache set to true and are associated with this logical resource in the current workspace. The value is greater than or equal to 0. This set is the same as the set filtered by imageCacheId in ListAllAgents. Agents with the feature disabled are not counted, and this value is independent of the number of occupied instances.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("agentCount")]
            [Validation(Required=false)]
            public long? AgentCount { get; set; }

            /// <summary>
            /// <para>The actual cache size in bytes. The known value is greater than or equal to 0. If the value is unknown, it is null. The compressed size of the source image cannot be used as a substitute.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("cacheSizeBytes")]
            [Validation(Required=false)]
            public long? CacheSizeBytes { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion is allowed. The value is true when there are no configuration references with the switch enabled, no valid instances occupying the resource, and the resource is not being deleted in the current workspace. If the reference status is unknown, the query should fail, and deletion cannot be allowed by default.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("canDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>The creation time of the logical resource in the current workspace, in RFC3339 format with time zone. The time is not refreshed when the content of the latest tag is updated.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T00:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The reason why deletion is blocked. The value is null when canDelete is true. Otherwise, the value is returned based on the priority of DELETING, AGENT_ENABLED, and INSTANCES_RELEASING. Even if the number of agents is 0, old instances may still occupy the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANCES_RELEASING</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("deleteBlockReason")]
            [Validation(Required=false)]
            public string DeleteBlockReason { get; set; }

            /// <summary>
            /// <para>The current content digest in the format of sha256: followed by a 64-character lowercase hexadecimal string. It only describes the currently registered content and does not prove that old instances have been switched.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</para>
            /// </summary>
            [NameInMap("digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The reason for the cache failure. This is a non-null object when the status is FAILED, and null for other statuses. It only describes the current content and the current creation round.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("error")]
            [Validation(Required=false)]
            public CreateImageCacheResponseBodyDataError Error { get; set; }
            public class CreateImageCacheResponseBodyDataError : TeaModel {
                /// <summary>
                /// <para>The secure and non-null error code for the current creation failure.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACSCacheBuildFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The secure and non-null display reason for the creation failure, excluding credentials, internal addresses, or stack traces.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed to create the image cache. Please try again</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The logical resource ID manageable by the current workspace, which is not a shared physical cache ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-example</para>
            /// </summary>
            [NameInMap("imageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The domain name of the source image, excluding the protocol, path, and credentials.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-registry.cn-hangzhou.cr.aliyuncs.com</para>
            /// </summary>
            [NameInMap("registry")]
            [Validation(Required=false)]
            public string Registry { get; set; }

            /// <summary>
            /// <para>The path of the source image repository in the namespace/repository format, which already includes the namespace.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>team/app</para>
            /// </summary>
            [NameInMap("repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// <para>The status of the image cache. Valid values: PENDING: creating, READY: available, FAILED: abnormal, DELETING: deleting in the current workspace.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag of the source image. Case is preserved. Regular tags cannot be registered with different digests, with the exact lowercase latest tag being the only exception.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The workspace ID, which is consistent with the requested workspace. Resources with the same content from other workspaces are not returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-example</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. This does not indicate that the cache creation is complete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
