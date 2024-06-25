// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateSecurityPolicyAttributeRequest : TeaModel {
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
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/443657.html) operation to obtain the region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the TLS security policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The name of the security policy.
        /// 
        /// The name must be 1 to 200 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("SecurityPolicyName")]
        [Validation(Required=false)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// The supported versions of the Transport Layer Security (TLS) protocol. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**. You can specify at most four TLS protocol versions.
        /// </summary>
        [NameInMap("TlsVersions")]
        [Validation(Required=false)]
        public List<string> TlsVersions { get; set; }

    }

}
