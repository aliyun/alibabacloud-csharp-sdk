// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days that data is automatically archived after the storage duration expires. A value of 0 indicates that data is not archived. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>V1 instances: 60 to 365.</para>
        /// </description></item>
        /// <item><description><para>V2 instances: 60 to 3650. A value of 3650 indicates that the data is permanently stored.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("archiveDuration")]
        [Validation(Required=false)]
        public int? ArchiveDuration { get; set; }

        /// <summary>
        /// <para>The policy for password-free read access. IP address ranges and VPC IDs are supported.</para>
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
        /// <para>The policy for password-free write access.</para>
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
        /// <para>Specifies whether to enable password-free read access. This feature is supported only for V2 instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable password-free write access. This feature is supported only for V2 instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable an authorization token. This feature is supported only for V1 instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <list type="bullet">
        /// <item><description><para>POSTPAY: pay-as-you-go based on the volume of reported metrics.</para>
        /// </description></item>
        /// <item><description><para>Note: If you leave this parameter empty, the default billing method is used. If a default billing method is not configured, POSTPAY is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage duration of the instance in days. The valid values depend on the billing method:</para>
        /// <list type="bullet">
        /// <item><description><para>For instances billed based on data written: 90 and 180.</para>
        /// </description></item>
        /// <item><description><para>For instances billed based on reported metrics: 15, 30, 60, 90, and 180.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusInstanceRequestTags> Tags { get; set; }
        public class CreatePrometheusInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110109200001214284</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The workspace to which the instance belongs. The default value is default-cms-{userId}-{regionId}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wokspace1</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
