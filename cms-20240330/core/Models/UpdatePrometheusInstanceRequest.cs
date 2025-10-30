// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to automatically archive and save after the storage expires, 0 means no archiving. The range of archiving days:
        /// V1: 1<del>365 days. Only supported for metric write volume.
        /// V2: 1</del>3650 days (3650 indicates permanent storage).</para>
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
        /// <para>Password-free read policy (supports IP segments and VpcId).</para>
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
        /// <para>Password-free write policy (supports IP segments and VpcId).</para>
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
        /// <para>Whether to enable password-free read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Whether to enable password-free write.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Whether to enable access token authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>Billing method (can only be modified once during the instance\&quot;s lifecycle):
        /// POSTPAY: Postpaid by metric reporting volume.
        /// POSTPAY_GB: Postpaid by metric write volume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY_GB</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-prom-name</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <para>Instance storage DB status (only supports RUNNING). If empty, the storage DB status will not be changed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Storage duration (days):
        /// By write volume: 90, 180.
        /// By metric reporting volume: 15, 30, 60, 90, 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        /// <summary>
        /// <para>Belonging workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-1500199863951574-cn-shanghai</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
