// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>Keep the default value unless you have special requirements. If you have special requirements, contact technical support to confirm and then specify the relevant parameters.</para>
        /// </remarks>
        /// <para>The attribute information.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string AttributesShrink { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client information.</para>
        /// </summary>
        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public string ClientInfoShrink { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PostPaid</c> (pay-as-you-go).</para>
        /// </remarks>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Hour: hour.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hour</para>
        /// </summary>
        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid (default): subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
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
        /// <para>Only one billing method is supported. If a billing method already exists, the new value is invalid by default, and the existing billing method prevails. Note that this parameter is required when you purchase the instance for the first time.</para>
        /// </remarks>
        /// <para>The network billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>95BandwidthByMonth: monthly 95th percentile bandwidth.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth. Unit: Mbit/s. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidth")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidth { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>InstanceChargeType</c> is set to <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>The subscription duration. Valid values (Note: If you select 12, the duration is calculated as one year. For other values, the unit is months):</para>
        /// <list type="bullet">
        /// <item><description>1 (default)</description></item>
        /// <item><description>2</description></item>
        /// <item><description>3</description></item>
        /// <item><description>4</description></item>
        /// <item><description>5</description></item>
        /// <item><description>6</description></item>
        /// <item><description>7</description></item>
        /// <item><description>8</description></item>
        /// <item><description>9</description></item>
        /// <item><description>12</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The specification of the cloud application service instance.</para>
        /// <list type="bullet">
        /// <item><description>If the specification belongs to the crs.cp.* series, the billing method can be subscription or pay-as-you-go.</description></item>
        /// <item><description>If the specification belongs to the crs.vm.* series, the billing method can be subscription or pay-as-you-go.</description></item>
        /// <item><description>For other series, only the subscription billing method is supported.</description></item>
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
        /// <para>The cloud storage capacity used by the cloud application service instance. Note: This is not local storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

    }

}
