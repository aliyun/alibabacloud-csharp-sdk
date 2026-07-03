// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSecretResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateSecretResponseBodyData Data { get; set; }
        public class CreateSecretResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sec-d5e6shmm1hkoxxxxxxxx</para>
            /// </summary>
            [NameInMap("secretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

        }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to upload data. Please try again</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CFF809D7-045D-502F-BF6C-947Exxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
