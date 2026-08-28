// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class PrecheckSkillUploadViaOssResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PrecheckSkillUploadViaOssResponseBodyData> Data { get; set; }
        public class PrecheckSkillUploadViaOssResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The version currently being edited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("editingVersion")]
            [Validation(Required=false)]
            public string EditingVersion { get; set; }

            /// <summary>
            /// <para>The entry path of the Skill package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL.md</para>
            /// </summary>
            [NameInMap("entryPath")]
            [Validation(Required=false)]
            public string EntryPath { get; set; }

            /// <summary>
            /// <para>Indicates whether the Skill already exists.</para>
            /// </summary>
            [NameInMap("exists")]
            [Validation(Required=false)]
            public bool? Exists { get; set; }

            /// <summary>
            /// <para>The highest published version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("maxPublishedVersion")]
            [Validation(Required=false)]
            public string MaxPublishedVersion { get; set; }

            /// <summary>
            /// <para>The resource owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The version parsed from the uploaded content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("parsedVersion")]
            [Validation(Required=false)]
            public string ParsedVersion { get; set; }

            /// <summary>
            /// <para>The pre-check result code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VALIDATION_FAILED</para>
            /// </summary>
            [NameInMap("precheckCode")]
            [Validation(Required=false)]
            public string PrecheckCode { get; set; }

            /// <summary>
            /// <para>The reason description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource processing completed</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The version currently under review.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("reviewingVersion")]
            [Validation(Required=false)]
            public string ReviewingVersion { get; set; }

            /// <summary>
            /// <para>The Skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-example</para>
            /// </summary>
            [NameInMap("skillName")]
            [Validation(Required=false)]
            public string SkillName { get; set; }

            /// <summary>
            /// <para>The target version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-1234567890abcdef</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-47A8-90AB-CDEF12345678</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
