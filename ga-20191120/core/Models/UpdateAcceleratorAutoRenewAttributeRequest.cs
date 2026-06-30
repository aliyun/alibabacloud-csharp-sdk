// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateAcceleratorAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of <b>AutoRenew</b> and <b>RenewalStatus</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: month.</para>
        /// <para>Valid values: <b>1</b> to <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The name of the Global Accelerator instance.</para>
        /// <para>The name must be 1 to 128 characters in length, start with a letter or a Chinese character, and can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The auto-renewal status of the Global Accelerator instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AutoRenewal</b>: The instance is configured for auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: The instance is configured for manual renewal.</para>
        /// </description></item>
        /// <item><description><para>NotRenewal: The instance is not renewed. The system does not send expiration reminders, but sends a non-renewal reminder three days before the expiration date. You can change the renewal status from <b>NotRenewal</b> to <b>Normal</b> to manually renew the instance, or change the renewal status to <b>AutoRenewal</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You must specify at least one of <b>AutoRenew</b> and <b>RenewalStatus</b>.</para>
        /// </description></item>
        /// <item><description><para>The <b>RenewalStatus</b> parameter takes precedence over the <b>AutoRenew</b> parameter. If you do not specify <b>RenewalStatus</b>, the value of <b>AutoRenew</b> is used.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
