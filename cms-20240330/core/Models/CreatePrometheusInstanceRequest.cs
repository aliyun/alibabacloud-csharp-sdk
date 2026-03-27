// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CreatePrometheusInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of days to automatically archive and save after the storage expires, 0 means no archiving. The range of archiving days is as follows:</para>
        /// <list type="bullet">
        /// <item><description>V1: 60~365 days.</description></item>
        /// <item><description>V2: 60~3650 days (3650 indicates permanent storage).</description></item>
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
        /// <para>Password-free write policy.</para>
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
        /// <para>Whether to enable password-free read (only supported in V2 version).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeRead")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeRead { get; set; }

        /// <summary>
        /// <para>Whether to enable password-free write (only supported in V2 version).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthFreeWrite")]
        [Validation(Required=false)]
        public bool? EnableAuthFreeWrite { get; set; }

        /// <summary>
        /// <para>Whether to enable authorization Token (only supported in V1 version).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableAuthToken")]
        [Validation(Required=false)]
        public bool? EnableAuthToken { get; set; }

        /// <summary>
        /// <para>Billing method:</para>
        /// <list type="bullet">
        /// <item><description>POSTPAY: Postpaid by metric reporting volume.</description></item>
        /// <item><description>POSTPAY_GB: Postpaid by metric write volume.
        /// Note, if left blank, the user\&quot;s default billing method configuration will be used. If the user has not configured a default, the system defaults to billing by metric reporting volume.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>Instance name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name1</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <para>Instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Storage duration (days):</para>
        /// <list type="bullet">
        /// <item><description>By write volume: 90, 180.</description></item>
        /// <item><description>By metric reporting volume: 15, 30, 60, 90, 180.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("storageDuration")]
        [Validation(Required=false)]
        public int? StorageDuration { get; set; }

        /// <summary>
        /// <para>Tag values.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<CreatePrometheusInstanceRequestTags> Tags { get; set; }
        public class CreatePrometheusInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110109200001214284</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Belonging workspace, default value: default-cms-{userId}-{regionId}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wokspace1</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
