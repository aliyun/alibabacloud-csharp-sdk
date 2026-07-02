// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8cad259f-4d77-40ec-bbd7-b9c47a423bb9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
