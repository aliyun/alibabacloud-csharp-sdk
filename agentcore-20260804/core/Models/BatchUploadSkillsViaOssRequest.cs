// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class BatchUploadSkillsViaOssRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public BatchUploadSkillsViaOssRequestBody Body { get; set; }
        public class BatchUploadSkillsViaOssRequestBody : TeaModel {
            /// <summary>
            /// <para>The OSS object name (path).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill/import/user123/ns-123456/2026/04/20/uuid/skills.zip</para>
            /// </summary>
            [NameInMap("ossObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <para>Specifies whether to overwrite an existing Skill. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overwrite")]
            [Validation(Required=false)]
            public bool? Overwrite { get; set; }

        }

    }

}
