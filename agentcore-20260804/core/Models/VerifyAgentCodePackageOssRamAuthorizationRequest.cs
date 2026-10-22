// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class VerifyAgentCodePackageOssRamAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>与 Workspace 同账号、同地域；不修改 Workspace 默认 OSS 绑定。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-bucket</para>
        /// </summary>
        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

    }

}
