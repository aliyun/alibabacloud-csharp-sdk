// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingInstanceRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>Unless you have specific requirements, keep the default values. For customers with special requirements, fill in the relevant parameters after communication and confirmation.</para>
        /// </remarks>
        /// <para>Attribute information.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public CreateRenderingInstanceRequestAttributes Attributes { get; set; }
        public class CreateRenderingInstanceRequestAttributes : TeaModel {
            /// <summary>
            /// <para>Streaming service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("EdgeMediaService")]
            [Validation(Required=false)]
            public string EdgeMediaService { get; set; }

            /// <summary>
            /// <para>Inbound access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("InAccess")]
            [Validation(Required=false)]
            public string InAccess { get; set; }

            /// <summary>
            /// <para>Outbound access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("OutAccess")]
            [Validation(Required=false)]
            public string OutAccess { get; set; }

            /// <summary>
            /// <para>Resource domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This value is valid only when <c>InstanceChargeType</c> is <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>Enable or disable auto-renewal. Values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Client information.</para>
        /// </summary>
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public CreateRenderingInstanceRequestClientInfo ClientInfo { get; set; }
        public class CreateRenderingInstanceRequestClientInfo : TeaModel {
            /// <summary>
            /// <para>Client IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.128.110</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

        }

        /// <summary>
        /// <remarks>
        /// <para>This value is valid only when <c>InstanceChargeType</c> is <c>PostPaid</c> (pay-as-you-go).</para>
        /// </remarks>
        /// <para>Billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour: Hourly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <para>The billing method for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid (default): Subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Only one billing method is allowed. If a billing method already exists, the new value is invalid by default, and the existing one prevails. Note that this field is required when a user makes the first purchase.</para>
        /// </remarks>
        /// <para>Network billing type. Value:</para>
        /// <list type="bullet">
        /// <item><description>95BandwidthByMonth: Monthly 95th percentile bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>Maximum bandwidth, in Mbps. Default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidth")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This value is valid only when <c>InstanceChargeType</c> is <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>The subscription period. Valid values (Note: 12 is converted to one year; other values are in months):</para>
        /// <list type="bullet">
        /// <item><description><para>1 (default)</para>
        /// </description></item>
        /// <item><description><para>2</para>
        /// </description></item>
        /// <item><description><para>3</para>
        /// </description></item>
        /// <item><description><para>4</para>
        /// </description></item>
        /// <item><description><para>5</para>
        /// </description></item>
        /// <item><description><para>6</para>
        /// </description></item>
        /// <item><description><para>7</para>
        /// </description></item>
        /// <item><description><para>8</para>
        /// </description></item>
        /// <item><description><para>9</para>
        /// </description></item>
        /// <item><description><para>12</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>Cloud application service instance specifications.</para>
        /// <list type="bullet">
        /// <item><description><para>For crs.cp.\* series specifications, choose between subscription or pay-as-you-go billing.</para>
        /// </description></item>
        /// <item><description><para>For crs.vm.\* series specifications, choose between subscription or pay-as-you-go billing.</para>
        /// </description></item>
        /// <item><description><para>For other series, only subscription billing is supported.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crs.cp.l1</para>
        /// </summary>
        [NameInMap("RenderingSpec")]
        [Validation(Required=false)]
        public string RenderingSpec { get; set; }

        /// <summary>
        /// <para>The cloud storage capacity used by the cloud application service instance (Note: not local storage).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

    }

}
