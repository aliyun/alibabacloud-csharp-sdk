// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillRequest : TeaModel {
        /// <summary>
        /// Bill Owner type.
        /// 
        ///  Value range:
        /// 
        /// 1: Master account 
        /// 
        /// 2: Sub account
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// Value Range:
        /// 
        /// MonthlyInvoice
        /// 
        /// MonthRefundInvoice
        /// 
        /// MonthlySummary
        /// 
        /// MonthlyInstanceAddAdjustBill 
        /// 
        /// MonthlyInstanceRefundBill
        /// 
        /// MonthlyAddAdjustInvoce
        /// 
        /// MonthlyRefundAdjustInvoce 
        /// 
        /// MonthlyInstanceConsumeV2 
        /// 
        /// MarginReportV2
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// Billing Month, Format is YYYY-MM
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

    }

}
