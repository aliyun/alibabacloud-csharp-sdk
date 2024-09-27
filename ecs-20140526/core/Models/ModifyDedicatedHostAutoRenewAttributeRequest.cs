// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostAutoRenewAttributeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically renew the subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: false</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically renew the subscription dedicated hosts along with the subscription ECS instances hosted on the dedicated hosts.</para>
        /// <para>If auto-renewal is enabled for the subscription ECS instances hosted on the subscription dedicated hosts, you can specify this parameter to automatically renew the dedicated hosts along with the subscription ECS instances. When the subscription ECS instances hosted on your dedicated hosts are automatically renewed, the subscription dedicated hosts are also automatically renewed if the expiration time of the dedicated hosts is earlier than the expiration time of the renewed instances. Take note of the following items:</para>
        /// <para>When the subscription dedicated hosts are configured to be automatically renewed along with the subscription ECS instances hosted on the dedicated hosts, the system checks the expiration time of the renewed instances and selects a minimum renewal duration for the dedicated hosts so that the dedicated hosts are renewed by a duration that ends later than the expiration time of the renewed instances. For more information about supported renewal durations, see the descriptions of the <c>PeriodUnit</c> and <c>Duration</c> parameters.</para>
        /// <para>For example, assume that a dedicated host expires on January 15 of the current year. Subscription ECS instances hosted on the dedicated host are configured to be automatically renewed to November 15 of the same year. The expiration time of the dedicated host is earlier than the expiration time of the ECS instances by 10 months. In this case, the system selects a renewal duration of 12 months (a minimum duration calculated based on a <c>Duration</c> value of 12 and a <c>PeriodUnit</c> value of Month) for the dedicated host. This ensures that the dedicated host expires later than the ECS instances.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewWithEcs: automatically renews the subscription dedicated hosts along with the subscription ECS instances hosted on the dedicated hosts.</description></item>
        /// <item><description>StopRenewWithEcs: does not automatically renew the subscription dedicated hosts along with the subscription ECS instances hosted on the dedicated hosts.</description></item>
        /// <item><description>NoOperation: does not change the current settings for the dedicated hosts.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to AutoRenewWithEcs, make sure that <c>AutoRenew</c> is set to true to enable auto-renewal for the dedicated hosts. Otherwise, the subscription dedicated hosts are not automatically renewed along with the subscription ECS instances hosted on the dedicated hosts.</para>
        /// </remarks>
        /// <para>Default value: NoOperation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StopRenewWithEcs</para>
        /// </summary>
        [NameInMap("AutoRenewWithEcs")]
        [Validation(Required=false)]
        public string AutoRenewWithEcs { get; set; }

        /// <summary>
        /// <para>The IDs of dedicated hosts. You can specify up to 100 subscription dedicated host IDs. Separate the IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp165p6xk2tlw61e****</para>
        /// </summary>
        [NameInMap("DedicatedHostIds")]
        [Validation(Required=false)]
        public string DedicatedHostIds { get; set; }

        /// <summary>
        /// <para>The renewal duration.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Month: 1 and 12</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Year: 1 and 12</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The unit of the renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <para>Default value: Month</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated host.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically renew the subscription dedicated host. The <c>RenewalStatus</c> parameter takes precedence over the <c>AutoRenew</c> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal: The dedicated hosts are automatically renewed.</description></item>
        /// <item><description>Normal: The dedicated hosts are not automatically renewed, and renewal notifications are sent.</description></item>
        /// <item><description>NotRenewal: The dedicated hosts are not automatically renewed, and no expiration notification is sent. A notification of no renewal is automatically sent three days before the end of the current subscription cycle. You can change the value of this parameter from NotRenewal to Normal and manually renew the dedicated hosts by calling the <a href="https://help.aliyun.com/document_detail/134250.html">RenewDedicatedHosts</a> operation. Alternatively, you can renew the dedicated hosts by setting this parameter to AutoRenewal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
