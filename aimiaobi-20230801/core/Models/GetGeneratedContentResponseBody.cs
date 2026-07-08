// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetGeneratedContentResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoData</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGeneratedContentResponseBodyData Data { get; set; }
        public class GetGeneratedContentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Rich text content</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Content generation domain. Valid values: media (news) and government (government services)</para>
            /// 
            /// <b>Example:</b>
            /// <para>media</para>
            /// </summary>
            [NameInMap("ContentDomain")]
            [Validation(Required=false)]
            public string ContentDomain { get; set; }

            /// <summary>
            /// <para>Plain text content</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("ContentText")]
            [Validation(Required=false)]
            public string ContentText { get; set; }

            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-04 11:46:07</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1&quot;</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Device ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <para>Document ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>List of words to ignore during content audit (JSON string)</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[{}]&quot;</para>
            /// </summary>
            [NameInMap("IgnoreContentAuditWords")]
            [Validation(Required=false)]
            public string IgnoreContentAuditWords { get; set; }

            /// <summary>
            /// <para>Keywords</para>
            /// </summary>
            [NameInMap("KeywordList")]
            [Validation(Required=false)]
            public List<string> KeywordList { get; set; }

            /// <summary>
            /// <para>Keywords (string format)</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;教师\&quot;,\&quot;乡村\&quot;]</para>
            /// </summary>
            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <para>Last prompt used to generate this content</para>
            /// 
            /// <b>Example:</b>
            /// <para>创作xxx文章</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>Session task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Title</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州亚运会</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>Update time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-04 11:46:07</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Updater</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1&quot;</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

            /// <summary>
            /// <para>UUID for traceability</para>
            /// 
            /// <b>Example:</b>
            /// <para>0961a514-2e26-4aa6-b22b-f592d145fe47</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1813ceee-7fe5-41b4-87e5-982a4d18cca5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. true indicates success. false indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
