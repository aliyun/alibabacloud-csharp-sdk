// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class CreateSecretValueResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C2B60C6-03CE-5F31-A8A4-13FCBEBACA1C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ciphertext ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>st-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("secretId")]
        [Validation(Required=false)]
        public string SecretId { get; set; }

    }

}
