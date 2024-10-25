// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyInstanceAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature. Valid values: <b>True and False</b>. Default value: False.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal period of the instance. Unit: months. Valid values: 1 to 9 and 12. This parameter is required if the AutoRenew parameter is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. Separate IDs with semicolons (;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance-test</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to renew the instance. The <b>RenewalStatus</b> parameter has a higher priority than the <b>AutoRenew</b> parameter. If you do not specify <b>RenewalStatus</b>, the <b>AutoRenew</b> parameter is used by default.</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: Auto-renewal is enabled for the instance.</description></item>
        /// <item><description>Normal: Auto-renewal is disabled for the instance.</description></item>
        /// <item><description>NotRenewal: The instance is not renewed.</description></item>
        /// </list>
        /// <para>The system no longer sends an expiration notification but sends only a renewal notification three days before the instance expires. To renew the instance, you can change the value of this parameter from NotRenewal to Normal and then manually renew the instance, or change the value of this parameter from NotRenewal to AutoRenewal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

    }

}
