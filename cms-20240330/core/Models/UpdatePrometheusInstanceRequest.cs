// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to store archived data after the storage duration expires. A value of 0 disables archiving. For V1 instances, the valid values are 1 to 365. This is supported only for the pay-by-data-write billing method. For V2 instances, the valid values are 1 to 3650. A value of 3650 indicates permanent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("archiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <para>The policy for password-free read access. The policy supports IP address segments and VPC IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;SourceIp&quot;: [
        ///     &quot;192.168.1.0/24&quot;,
        ///     &quot;172.168.2.22&quot;
        ///   ],
        ///   &quot;SourceVpc&quot;: [
        ///     &quot;vpc-xx1&quot;,
        ///     &quot;vpc-xx2&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("authFreeReadPolicy")]
        [Validation(Required=false)]
        public string AuthFreeReadPolicy { get; set; }

        /// <summary>
        /// <para>The policy for password-free write access. The policy supports IP address segments and VPC IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;SourceIp&quot;: [
        ///     &quot;192.168.1.0/24&quot;,
        ///     &quot;172.168.2.22&quot;
        ///   ],
        ///   &quot;SourceVpc&quot;: [
        ///     &quot;vpc-xx1&quot;,
        ///     &quot;vpc-xx2&quot;
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("authFreeWritePolicy")]
        [Validation(Required=false)]
        public string AuthFreeWritePolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free read access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free write access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication with an access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>The billing method. You can change the billing method only once during the instance lifecycle. Valid values: \<c>POSTPAY\\</c> (pay-as-you-go based on reported metrics) and \<c>POSTPAY_GB\\</c> (pay-as-you-go based on data writes).</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY_GB</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-prom-name</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <para>The status of the instance storage database. Only RUNNING is supported. If this parameter is left empty, the status of the storage database is not changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage duration in days. If the instance is billed by data writes, valid values are 90 and 180. If the instance is billed by reported metrics, valid values are 15, 30, 60, 90, and 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        /// <summary>
        /// <para>The workspace to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1500199863951574-cn-shanghai</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
