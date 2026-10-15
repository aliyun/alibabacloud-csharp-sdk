// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class UnsubscribeBillToOSSRequest : TeaModel {
        /// <summary>
        /// <para>For multi-level accounts, specifies the type of bill to push. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MA: Pushes the bill of the main account.</description></item>
        /// <item><description>ACP1: Pushes the bill of the Partner Platform V2.0 sub-account.</description></item>
        /// </list>
        /// <para>Default value: MA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MA</para>
        /// </summary>
        [NameInMap("MultAccountRelSubscribe")]
        [Validation(Required=false)]
        public string MultAccountRelSubscribe { get; set; }

        /// <summary>
        /// <para>The subscription type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BillingItemDetailForBillingPeriod: billable item-level consumption details.</description></item>
        /// <item><description>InstanceDetailForBillingPeriod: instance-level consumption details.</description></item>
        /// <item><description>BillingItemDetailMonthly: billable item-level consumption summary by billing cycle.</description></item>
        /// <item><description>InstanceDetailMonthly: instance-level consumption summary by billing cycle.</description></item>
        /// <item><description>SplitItemDetailDaily: split bill summarized by day.</description></item>
        /// <item><description>MonthBill: monthly bill in PDF format. Only MA subscriptions are supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BillingItemDetailForBillingPeriod</para>
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
