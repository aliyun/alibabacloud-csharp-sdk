// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDynamicDictUploadInfoResponseBody : TeaModel {
        /// <summary>
        /// The AccessKey ID that is used to access OSS.
        /// </summary>
        [NameInMap("Accessid")]
        [Validation(Required=false)]
        public string Accessid { get; set; }

        /// <summary>
        /// The validity period of the signature. The value is a UNIX timestamp.
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// The OSS endpoint.
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// The name of the OSS object.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The OSS security policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The signature that is calculated based on **AccessKeySecret** and **Policy**. When you call an OSS API operation, OSS uses the signature information to check the validity of the POST request.
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
