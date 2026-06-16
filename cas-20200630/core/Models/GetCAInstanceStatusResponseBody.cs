// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status details of the private CA instance.</para>
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<GetCAInstanceStatusResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class GetCAInstanceStatusResponseBodyInstanceStatusList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the private CA certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>This parameter is returned only if <b>Status</b> is <b>USED</b> (the private CA instance is enabled) or <b>REVOKE</b> (the private CA instance is revoked).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1792944000000</para>
            /// </summary>
            [NameInMap("AfterTime")]
            [Validation(Required=false)]
            public long? AfterTime { get; set; }

            /// <summary>
            /// <para>The issuance date of the private CA certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>This parameter is returned only if <b>Status</b> is <b>USED</b> (the private CA instance is enabled) or <b>REVOKE</b> (the private CA instance is revoked).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1635177600000</para>
            /// </summary>
            [NameInMap("BeforeTime")]
            [Validation(Required=false)]
            public long? BeforeTime { get; set; }

            /// <summary>
            /// <para>The number of certificates that the private CA instance has issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CertIssuedCount")]
            [Validation(Required=false)]
            public int? CertIssuedCount { get; set; }

            /// <summary>
            /// <para>The number of certificates that the private CA instance can issue.</para>
            /// <para>If the private CA is a root CA (<b>Type</b> is <b>ROOT</b>), this parameter indicates the number of intermediate CA certificates that can be issued. If the private CA is an intermediate CA (<b>Type</b> is <b>SUB_ROOT</b>), this parameter indicates the total number of client certificates and server-side certificates that can be issued.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CertTotalCount")]
            [Validation(Required=false)]
            public int? CertTotalCount { get; set; }

            /// <summary>
            /// <para>The unique identifier of the private CA certificate.</para>
            /// <remarks>
            /// <para>This parameter is returned only if <b>Status</b> is <b>USED</b> (the private CA instance is enabled) or <b>REVOKE</b> (the private CA instance is revoked).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>a7bb2dd212a2112128cd5cc9b753****</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The ID of the private CA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cas-member-0hmi****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the private CA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BUY</b>: The instance is purchased but not enabled.</para>
            /// </description></item>
            /// <item><description><para><b>USED</b>: The instance is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>REFUND</b>: A refund has been issued for the instance.</para>
            /// </description></item>
            /// <item><description><para><b>REVOKE</b>: The instance is revoked.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the private CA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ROOT</b>: Root CA instance.</para>
            /// </description></item>
            /// <item><description><para><b>SUB_ROOT</b>: Intermediate CA instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROOT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The expiration date of the private CA instance. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para>This parameter corresponds to the subscription duration that you selected for the Private Certificate Authority (PCA) service when you purchased the instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1637251200000</para>
            /// </summary>
            [NameInMap("UseExpireTime")]
            [Validation(Required=false)]
            public long? UseExpireTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25589516-2A56-5159-AB88-4A1D9824E183</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
