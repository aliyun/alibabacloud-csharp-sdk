// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UploadAgentSpecViaOssRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UploadAgentSpecViaOssRequestBody Body { get; set; }
        public class UploadAgentSpecViaOssRequestBody : TeaModel {
            /// <summary>
            /// <para>The OSS object name (full path).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agentspec/export/user1/ns1/2024-01-01/uuid/123456.zip</para>
            /// </summary>
            [NameInMap("ossObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            /// <summary>
            /// <para>Specifies whether to overwrite existing drafts. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("overwrite")]
            [Validation(Required=false)]
            public bool? Overwrite { get; set; }

            /// <summary>
            /// <para>Specifies whether to publish immediately after upload. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("publish")]
            [Validation(Required=false)]
            public bool? Publish { get; set; }

        }

    }

}
