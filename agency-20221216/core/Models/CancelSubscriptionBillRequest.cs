// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CancelSubscriptionBillRequest : TeaModel {
        /// <summary>
        /// <para>Subscription type.</para>
        /// <list type="bullet">
        /// <item><description>PartnerBillingItemDetailForBillingPeriod: Billing item bill details.</description></item>
        /// <item><description>PartnerBillingItemDetailMonthly: Billing item monthly bill.</description></item>
        /// <item><description>PartnerInstanceDetailForBillingPeriod: Instance bill details.</description></item>
        /// <item><description>PartnerInstanceDetailMonthly: Instance monthly bill.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PartnerBillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
