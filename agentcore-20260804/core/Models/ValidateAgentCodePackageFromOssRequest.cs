// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ValidateAgentCodePackageFromOssRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ValidateAgentCodePackageFromOssRequestBody Body { get; set; }
        public class ValidateAgentCodePackageFromOssRequestBody : TeaModel {
            /// <summary>
            /// <para>The name of the source OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-bucket</para>
            /// </summary>
            [NameInMap("ossBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The full object key of the source code package.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>packages/main.zip</para>
            /// </summary>
            [NameInMap("ossObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

        }

    }

}
