// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetSkillVersionDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSkillVersionDetailResponseBodyData Data { get; set; }
        public class GetSkillVersionDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A sample description that explains the purpose of the resource</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-example</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource mapping (key is the resource name).</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public Dictionary<string, DataResourceValue> Resource { get; set; }

            /// <summary>
            /// <para>The Skill card content (SKILL.md).</para>
            /// 
            /// <b>Example:</b>
            /// <h1>Sample Skill</h1>
            /// <para>Used to demonstrate Skill document content</para>
            /// </summary>
            [NameInMap("skillMd")]
            [Validation(Required=false)]
            public string SkillMd { get; set; }

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
