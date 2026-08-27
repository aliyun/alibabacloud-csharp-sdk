// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The Common Name of the certificate. This field is empty when SSL is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.polarclaw.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        /// <summary>
        /// <para>The certificate expiration time in UTC. This field is empty when SSL is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-08-09T10:23:26Z</para>
        /// </summary>
        [NameInMap("CertExpiredTime")]
        [Validation(Required=false)]
        public string CertExpiredTime { get; set; }

        /// <summary>
        /// <para>The SHA-256 (DER) fingerprint of the server certificate in lowercase hex. Use this value for client pinning. This is consistent with openssl -fingerprint -sha256. This field is empty when SSL is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20769803152bf6a3abed626f6b8cae3a1f0d0f2c3b4a59687776655443322110</para>
        /// </summary>
        [NameInMap("CertFingerprintSha256Der")]
        [Validation(Required=false)]
        public string CertFingerprintSha256Der { get; set; }

        /// <summary>
        /// <para>The most recent certificate installation time in UTC. This field is empty when SSL is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-09T10:23:49Z</para>
        /// </summary>
        [NameInMap("CertModifiedTime")]
        [Validation(Required=false)]
        public string CertModifiedTime { get; set; }

        /// <summary>
        /// <para>The certificate source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ca: issued by the platform.</description></item>
        /// <item><description>customer: provided by the user.</description></item>
        /// </list>
        /// <para>This field is empty when SSL is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca</para>
        /// </summary>
        [NameInMap("CertSource")]
        [Validation(Required=false)]
        public string CertSource { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2F029645-FED9-4FE8-A6D3-488954******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic rotation of platform-issued certificates is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public bool? SSLAutoRotate { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

    }

}
