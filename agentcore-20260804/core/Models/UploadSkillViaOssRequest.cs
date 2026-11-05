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
            /// <para>The name or path of the OSS object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imports/example.zip</para>
            /// </summary>
            [NameInMap("ossObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <para>Specifies whether to overwrite an existing skill. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overwrite")]
            [Validation(Required=false)]
            public bool? Overwrite { get; set; }

            /// <summary>
            /// <para>The target version to upload. This parameter is optional and serves as a fallback when no version information is included in the ZIP package.</para>
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
