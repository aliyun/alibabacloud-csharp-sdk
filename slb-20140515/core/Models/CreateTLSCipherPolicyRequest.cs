// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateTLSCipherPolicyRequest : TeaModel {
        /// <summary>
        /// The supported cipher suites, which are determined by the TLS protocol version. You can specify at most 32 cipher suites.
        /// 
        /// TLS 1.0 and TLS 1.1 support the following cipher suites:
        /// 
        /// *   **ECDHE-ECDSA-AES128-SHA**
        /// *   **ECDHE-ECDSA-AES256-SHA**
        /// *   **ECDHE-RSA-AES128-SHA**
        /// *   **ECDHE-RSA-AES256-SHA**
        /// *   **AES128-SHA**
        /// *   **AES256-SHA**
        /// *   **DES-CBC3-SHA**
        /// 
        /// TLS 1.2 supports the following cipher suites:
        /// 
        /// *   **ECDHE-ECDSA-AES128-SHA**
        /// *   **ECDHE-ECDSA-AES256-SHA**
        /// *   **ECDHE-RSA-AES128-SHA**
        /// *   **ECDHE-RSA-AES256-SHA**
        /// *   **AES128-SHA**
        /// *   **AES256-SHA**
        /// *   **DES-CBC3-SHA**
        /// *   **ECDHE-ECDSA-AES128-GCM-SHA256**
        /// *   **ECDHE-ECDSA-AES256-GCM-SHA384**
        /// *   **ECDHE-ECDSA-AES128-SHA256**
        /// *   **ECDHE-ECDSA-AES256-SHA384**
        /// *   **ECDHE-RSA-AES128-GCM-SHA256**
        /// *   **ECDHE-RSA-AES256-GCM-SHA384**
        /// *   **ECDHE-RSA-AES128-SHA256**
        /// *   **ECDHE-RSA-AES256-SHA384**
        /// *   **AES128-GCM-SHA256**
        /// *   **AES256-GCM-SHA384**
        /// *   **AES128-SHA256**
        /// *   **AES256-SHA256**
        /// 
        /// TLS 1.3 supports the following cipher suites:
        /// 
        /// *   **TLS_AES_128_GCM_SHA256**
        /// *   **TLS_AES_256_GCM_SHA384**
        /// *   **TLS_CHACHA20_POLY1305_SHA256**
        /// *   **TLS_AES_128_CCM_SHA256**
        /// *   **TLS_AES_128_CCM_8_SHA256**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// The name of the TLS policy. The name must be 1 to 200 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).
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
        /// The ID of the region where the Server Load Balancer (SLB) instance is created.
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
        /// The version of the TLS protocol. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**. You can specify at most four TLS versions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TLSVersions")]
        [Validation(Required=false)]
        public List<string> TLSVersions { get; set; }

    }

}
