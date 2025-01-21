// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class GetCAInstanceStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status information of the private CA instance.</para>
        /// </summary>
        [NameInMap("InstanceStatusList")]
        [Validation(Required=false)]
        public List<GetCAInstanceStatusResponseBodyInstanceStatusList> InstanceStatusList { get; set; }
        public class GetCAInstanceStatusResponseBodyInstanceStatusList : TeaModel {
            /// <summary>
            /// <para>The expiration date of the private CA certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the value of the <b>Status</b> parameter is <b>USED</b> or <b>REVOKE</b>. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.</para>
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
            /// <para> This parameter is returned only when the value of the <b>Status</b> parameter is <b>USED</b> or <b>REVOKE</b>. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1635177600000</para>
            /// </summary>
            [NameInMap("BeforeTime")]
            [Validation(Required=false)]
            public long? BeforeTime { get; set; }

            /// <summary>
            /// <para>The number of certificates that are issued by using the private CA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CertIssuedCount")]
            [Validation(Required=false)]
            public int? CertIssuedCount { get; set; }

            /// <summary>
            /// <para>The number of certificates that can be issued by using the private CA instance.</para>
            /// <para>For a private root CA instance whose <b>Type</b> is <b>ROOT</b>, this parameter indicates the number of intermediate CA certificates that can be issued.</para>
            /// <para>For a private intermediate CA instance whose <b>Type</b> is <b>SUB_ROOT</b>, this parameter indicates the total number of client certificates and server certificates that can be issued</para>
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
            /// <para> This parameter is returned only when the value of the <b>Status</b> parameter is <b>USED</b> or <b>REVOKE</b>. The value USED indicates that the private CA instance is enabled, and the value REVOKE indicates that the instance is revoked.</para>
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
            /// <item><description><b>BUY</b>: The private CA instance is purchased but is not enabled.</description></item>
            /// <item><description><b>USED</b>: The private CA instance is enabled.</description></item>
            /// <item><description><b>REFUND</b>: The private CA instance is refunded.</description></item>
            /// <item><description><b>REVOKE</b>: The private CA instance is revoked.</description></item>
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
            /// <item><description><b>ROOT</b>: root CA instance</description></item>
            /// <item><description><b>SUB_ROOT</b>: intermediate CA instance</description></item>
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
            /// <para> This parameter corresponds to the duration that you select when you purchase the private CA instance. The duration indicates the subscription period of the Private Certificate Authority (PCA) service.</para>
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
