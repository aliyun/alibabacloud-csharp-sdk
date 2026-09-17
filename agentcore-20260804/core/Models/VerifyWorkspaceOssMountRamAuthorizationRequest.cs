// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class VerifyWorkspaceOssMountRamAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The OSS bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket-001</para>
        /// </summary>
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

    }

}
