// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether payment is automatically made during renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: Automatic payment is enabled. Make sure that your Alibaba Cloud account has adequate balance.</description></item>
        /// <item><description><b>False</b>: Automatic payment is disabled. You have to manually pay in the console. Log on to the console. In the upper-right corner, choose <b>Expenses &gt; User Center</b>. In the left-side navigation pane, click <b>Orders</b>. On the page that appears, find your order and complete the payment.</description></item>
        /// </list>
        /// <para>Default value: <b>False</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigateway-cn-v6419k43xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The specifications of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.s1.small</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to upgrade or downgrade the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UPGRADE</b></description></item>
        /// <item><description><b>DOWNGRADE</b></description></item>
        /// </list>
        /// <para>Default value: <b>UPGRADE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("ModifyAction")]
        [Validation(Required=false)]
        public string ModifyAction { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the Waiting for Traffic Switchover state. During the upgrade or downgrade, a new outbound IP address may be added to the API Gateway instance. The Waiting for Traffic Switchover state is used to remind users of adding the new outbound IP address to the whitelist. If you set the SkipWaitSwitch parameter to true, the instance does not enter the Waiting for Traffic Switchover state when a new outbound IP address is available. Instead, the system sends internal messages to the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipWaitSwitch")]
        [Validation(Required=false)]
        public bool? SkipWaitSwitch { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5845042-2f2f-4e96-bd5c-36c6e5c2a68c</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
