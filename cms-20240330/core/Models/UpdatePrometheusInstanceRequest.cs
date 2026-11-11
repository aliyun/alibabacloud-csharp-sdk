// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to automatically archive and retain data after the storage period expires. A value of 0 indicates that data is not archived. Valid values for the archive retention period:
        /// V1: 1 to 365 days. Supported only for the pay-by-ingested-data billing method.
        /// V2: 1 to 3650 days. A value of 3650 indicates permanent retention.</para>
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
        /// <para>The authentication-free read policy. IP address ranges and VPC IDs are supported.</para>
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
        /// <para>The authentication-free read policy. IP address ranges and VPC IDs are supported.</para>
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <para>true: sends a precheck request without updating the instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the DryRunOperation error code is returned.
        /// false: sends a regular request. If the request passes the precheck, the instance is updated. This is the default value.</para>
        /// </summary>
        [NameInMap("dryrun")]
        [Validation(Required=false)]
        public bool? Dryrun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication-free read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable authentication-free write.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access token authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>The billing method. You can change the billing method only once during the lifecycle of the instance. Valid values:
        /// POSTPAY: pay-as-you-go based on the number of reported metrics.
        /// POSTPAY_GB: pay-as-you-go based on the volume of ingested data.</para>
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
        /// <para>The storage duration in days. Valid values:
        /// For the pay-by-ingested-data billing method: 90 and 180.
        /// For the pay-by-reported-metrics billing method: 15, 30, 60, 90, and 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        /// <summary>
        /// <para>The Prometheus storage configuration.</para>
        /// </summary>
        [NameInMap("storeConfig")]
        [Validation(Required=false)]
        public PrometheusInstanceStoreConfig StoreConfig { get; set; }

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
