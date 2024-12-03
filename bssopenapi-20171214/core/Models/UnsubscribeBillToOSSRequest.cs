// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class UnsubscribeBillToOSSRequest : TeaModel {
        /// <summary>
        /// <para>The type of accounts whose bills are to be pushed if multi-tier accounts are involved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MA: management account.</description></item>
        /// <item><description>ACP1: member account of a virtual network operator (VNO).</description></item>
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
        /// <para>The type of the bill to which you want to subscribe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BillingItemDetailForBillingPeriod: bills of billable items</description></item>
        /// <item><description>InstanceDetailForBillingPeriod: bills of instances</description></item>
        /// <item><description>BillingItemDetailMonthly: billable item-based bills summarized by billing cycle</description></item>
        /// <item><description>InstanceDetailMonthly: instance-based bills summarized by billing cycle</description></item>
        /// <item><description>SplitItemDetailDaily: split bills summarized by day</description></item>
        /// <item><description>MonthBill: monthly bills in the PDF format You can subscribe to the monthly PDF bills only of the master account.</description></item>
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
