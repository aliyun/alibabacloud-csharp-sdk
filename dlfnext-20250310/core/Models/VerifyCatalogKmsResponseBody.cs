// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class VerifyCatalogKmsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when the validation fails. An empty string is returned when the validation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KeyNotFound</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The description of the failure cause and remediation suggestions returned when the validation fails. An empty string is returned when the validation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter KMS keyId is not found.</para>
        /// </summary>
        [NameInMap("hint")]
        [Validation(Required=false)]
        public string Hint { get; set; }

        /// <summary>
        /// <para>The KMS key identifier actually used by the probe object. When the validation is successful, this corresponds to the customer master key (CMK) specified in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-1234567890abcdef</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The server-side encryption method actually used by the probe object. Returns KMS when the validation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMS</para>
        /// </summary>
        [NameInMap("serverSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// <para>Indicates whether the validation is successful. A value of true indicates that the write probe succeeded and the SSE-KMS configuration of the object meets expectations. A value of false indicates that the validation failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
