// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetTLSCipherPolicyAttributeRequest : TeaModel {
        /// <summary>
        /// The cipher suites supported by the TLS version.
        /// 
        /// The specified cipher suites must be supported by at least one TLS protocol version that you specify. For example, if you set the TLSVersions parameter to TLSv1.3, you must specify cipher suites that are supported by this protocol version.
        /// 
        /// TLS 1.0 and TLS 1.1 support the following cipher suites:
        /// 
        /// *   ECDHE-ECDSA-AES128-SHA
        /// *   ECDHE-ECDSA-AES256-SHA
        /// *   ECDHE-RSA-AES128-SHA
        /// *   ECDHE-RSA-AES256-SHA
        /// *   AES128-SHA AES256-SHA
        /// *   DES-CBC3-SHA
        /// 
        /// TLS 1.2 supports the following cipher suites:
        /// 
        /// *   ECDHE-ECDSA-AES128-SHA
        /// *   ECDHE-ECDSA-AES256-SHA
        /// *   ECDHE-RSA-AES128-SHA
        /// *   ECDHE-RSA-AES256-SHA
        /// *   AES128-SHA AES256-SHA
        /// *   DES-CBC3-SHA
        /// *   ECDHE-ECDSA-AES128-GCM-SHA256
        /// *   ECDHE-ECDSA-AES256-GCM-SHA384
        /// *   ECDHE-ECDSA-AES128-SHA256
        /// *   ECDHE-ECDSA-AES256-SHA384
        /// *   ECDHE-RSA-AES128-GCM-SHA256
        /// *   ECDHE-RSA-AES256-GCM-SHA384
        /// *   ECDHE-RSA-AES128-SHA256
        /// *   ECDHE-RSA-AES256-SHA384
        /// *   AES128-GCM-SHA256
        /// *   AES256-GCM-SHA384
        /// *   AES128-SHA256 AES256-SHA256
        /// 
        /// TLS 1.3 supports the following cipher suites:
        /// 
        /// *   TLS_AES_128_GCM_SHA256
        /// *   TLS_AES_256_GCM_SHA384
        /// *   TLS_CHACHA20_POLY1305_SHA256
        /// *   TLS_AES_128_CCM_SHA256
        /// *   TLS_AES_128_CCM_8_SHA256
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// The name of the TLS policy. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Server Load Balancer (SLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the TLS policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TLSCipherPolicyId")]
        [Validation(Required=false)]
        public string TLSCipherPolicyId { get; set; }

        /// <summary>
        /// The version of the TLS protocol. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TLSVersions")]
        [Validation(Required=false)]
        public List<string> TLSVersions { get; set; }

    }

}
