// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetSkillDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about the skill.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillDetailResponseBodyData Data { get; set; }
        public class GetSkillDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The business tags as a JSON array string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("BizTags")]
            [Validation(Required=false)]
            public string BizTags { get; set; }

            /// <summary>
            /// <para>The skill description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kms-rds-rduphoenix-val-mysql kms key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The total number of downloads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DownloadCount")]
            [Validation(Required=false)]
            public long? DownloadCount { get; set; }

            /// <summary>
            /// <para>The version that is being edited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.3</para>
            /// </summary>
            [NameInMap("EditingVersion")]
            [Validation(Required=false)]
            public string EditingVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the skill is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The source tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aqs</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }

            /// <summary>
            /// <para>The version label mapping.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            /// <summary>
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0521B历史1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing:beta</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The number of online versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnlineCnt")]
            [Validation(Required=false)]
            public int? OnlineCnt { get; set; }

            /// <summary>
            /// <para>The UID of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>199458752209xxxx</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The version that is under review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.2</para>
            /// </summary>
            [NameInMap("ReviewingVersion")]
            [Validation(Required=false)]
            public string ReviewingVersion { get; set; }

            /// <summary>
            /// <para>The visibility scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-06T06:37Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The list of all version summaries.</para>
            /// </summary>
            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<GetSkillDetailResponseBodyDataVersions> Versions { get; set; }
            public class GetSkillDetailResponseBodyDataVersions : TeaModel {
                /// <summary>
                /// <para>The author.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22618</para>
                /// </summary>
                [NameInMap("Author")]
                [Validation(Required=false)]
                public string Author { get; set; }

                /// <summary>
                /// <para>The version commit message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>版本1说明。</para>
                /// </summary>
                [NameInMap("CommitMsg")]
                [Validation(Required=false)]
                public string CommitMsg { get; set; }

                /// <summary>
                /// <para>The timestamp when the file was created, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-12-02T02:12:01Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataphin_300067022_pre</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The number of downloads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DownloadCount")]
                [Validation(Required=false)]
                public long? DownloadCount { get; set; }

                /// <summary>
                /// <para>The skill review information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;executionId&quot;: &quot;54408ebe-3c19-4e2e-82a3-f400cedfcd24&quot;,
                ///   &quot;status&quot;: &quot;APPROVED&quot;,
                ///   &quot;pipeline&quot;: [
                ///     {
                ///       &quot;nodeId&quot;: &quot;fence&quot;,
                ///       &quot;executedAt&quot;: &quot;2026-05-21T07:42:24.684194457Z&quot;,
                ///       &quot;passed&quot;: true,
                ///       &quot;messageType&quot;: &quot;json&quot;,
                ///       &quot;message&quot;: {
                ///         &quot;resultCode&quot;: &quot;PASS_PARTIAL_SKIP&quot;,
                ///         &quot;reports&quot;: [
                ///           {
                ///             &quot;file&quot;: &quot;SKILL.md&quot;,
                ///             &quot;taskId&quot;: &quot;E25BDA44-6E10-51AF-B6AB-417EBB4CEF40&quot;,
                ///             &quot;riskLevel&quot;: &quot;none&quot;
                ///           },
                ///           {
                ///             &quot;file&quot;: &quot;pdf-3/presentation.pptx&quot;,
                ///             &quot;taskId&quot;: &quot;BEEC2D66-B9AE-5C4F-828D-BFAB6E561891&quot;,
                ///             &quot;riskLevel&quot;: &quot;skip&quot;,
                ///             &quot;errorCode&quot;: &quot;500&quot;,
                ///             &quot;errorMessage&quot;: &quot;Scan failed. Please contact us through the online service.&quot;
                ///           }
                ///         ]
                ///       },
                ///       &quot;checkpoints&quot;: [
                ///         {
                ///           &quot;title&quot;: &quot;promptAttack&quot;,
                ///           &quot;passed&quot;: true
                ///         },
                ///         {
                ///           &quot;title&quot;: &quot;contentModeration&quot;,
                ///           &quot;passed&quot;: true
                ///         }
                ///       ],
                ///       &quot;durationMs&quot;: 18933
                ///     }
                ///   ]
                /// }</para>
                /// </summary>
                [NameInMap("PublishPipelineInfo")]
                [Validation(Required=false)]
                public string PublishPipelineInfo { get; set; }

                /// <summary>
                /// <para>The resource status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-06T06:37Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-01</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the skill can be edited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Writeable")]
            [Validation(Required=false)]
            public bool? Writeable { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID generated by Alibaba Cloud for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5272879-3C44-5E5A-8056-CB4E8EB36DCD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
