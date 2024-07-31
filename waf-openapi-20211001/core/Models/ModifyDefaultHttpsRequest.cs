// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefaultHttpsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        [NameInMap("CipherSuite")]
        [Validation(Required=false)]
        public int? CipherSuite { get; set; }

        [NameInMap("CustomCiphers")]
        [Validation(Required=false)]
        public List<string> CustomCiphers { get; set; }

        [NameInMap("EnableTLSv3")]
        [Validation(Required=false)]
        public bool? EnableTLSv3 { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TLSVersion")]
        [Validation(Required=false)]
        public string TLSVersion { get; set; }

    }

}
