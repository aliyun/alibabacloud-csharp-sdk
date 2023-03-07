// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class UnsubscribeBillToOSSRequest : TeaModel {
        /// <summary>
        /// The type of accounts whose bills are to be pushed if multi-tier accounts are involved. Valid values:
        /// 
        /// *   MA: management account.
        /// *   ACP1: member account of a virtual network operator (VNO).
        /// 
        /// Default value: MA.
        /// </summary>
        [NameInMap("MultAccountRelSubscribe")]
        [Validation(Required=false)]
        public string MultAccountRelSubscribe { get; set; }

        /// <summary>
        /// The type of the bill to which you want to subscribe. Valid values:
        /// 
        /// *   BillingItemDetailForBillingPeriod: bills of billable items
        /// *   InstanceDetailForBillingPeriod: bills of instances
        /// *   BillingItemDetailMonthly: billable item-based bills summarized by billing cycle
        /// *   InstanceDetailMonthly: instance-based bills summarized by billing cycle
        /// *   SplitItemDetailDaily: split bills summarized by day
        /// *   MonthBill: monthly bills in the PDF format You can subscribe to the monthly PDF bills only of the master account.
        /// </summary>
        [NameInMap("SubscribeType")]
        [Validation(Required=false)]
        public string SubscribeType { get; set; }

    }

}
