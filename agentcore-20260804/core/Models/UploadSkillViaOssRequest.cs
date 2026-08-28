// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UploadSkillViaOssRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UploadSkillViaOssRequestBody Body { get; set; }
        public class UploadSkillViaOssRequestBody : TeaModel {
            /// <summary>
            /// <para>The commit message. This parameter is optional.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Update documentation</para>
            /// </summary>
            [NameInMap("commitMsg")]
            [Validation(Required=false)]
            public string CommitMsg { get; set; }

            /// <summary>
            /// <para>The OSS object name (path).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imports/example.zip</para>
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

            /// <summary>
            /// <para>The upload version number. This parameter is optional and used as a fallback when the ZIP package contains no version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("targetVersion")]
            [Validation(Required=false)]
            public string TargetVersion { get; set; }

        }

    }

}
