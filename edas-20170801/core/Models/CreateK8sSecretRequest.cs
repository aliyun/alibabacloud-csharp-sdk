// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateK8sSecretRequest : TeaModel {
        /// <summary>
        /// Specifies whether the data has been encoded in Base64. Valid values: true and false.
        /// </summary>
        [NameInMap("Base64Encoded")]
        [Validation(Required=false)]
        public bool? Base64Encoded { get; set; }

        /// <summary>
        /// The certificate ID provided by Alibaba Cloud Certificate Management Service.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// The region in which the certificate is stored.
        /// </summary>
        [NameInMap("CertRegionId")]
        [Validation(Required=false)]
        public string CertRegionId { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The data of the Secret. The value must be a JSON array that contains the following information:
        /// 
        /// *   Key: Secret key
        /// *   Value: Secret value
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The name of the Secret. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 63 characters in length.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The namespace of the Kubernetes cluster.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The Secret type. Valid values:
        /// 
        /// *   Opaque: user-defined data
        /// *   kubernetes.io/tls: Transport Layer Security (TLS) certificate
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
