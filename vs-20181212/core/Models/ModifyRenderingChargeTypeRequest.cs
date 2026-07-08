// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyRenderingChargeTypeRequest : TeaModel {
        /// <summary>
        /// <remarks>
        /// <para>This value is valid only when <c>InstanceChargeType</c> is <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>Enable or disable auto-renewal. Valid values:</para>
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
        /// <para>The target billing method for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PrePaid (default): Subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This value is valid only when <c>InstanceChargeType</c> is <c>PrePaid</c> (subscription).</para>
        /// </remarks>
        /// <para>The duration for subscription. Valid values (Note: If you select 12, it converts to one year; other values are in months):</para>
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
        /// <para>The ID of the Graphic Computing Service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
