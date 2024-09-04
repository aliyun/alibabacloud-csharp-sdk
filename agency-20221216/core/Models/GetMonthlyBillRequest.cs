// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillRequest : TeaModel {
        /// <summary>
        /// Bill Owner type. Value Range:</br>
        /// 1: Master account</br>
        /// 2: Sub account</br>
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// Value Range:
        /// 
        /// - MonthlyInvoice
        /// - MonthRefundInvoice
        /// - MonthlySummary
        /// - MonthlyInstanceAddAdjustBill 
        /// - MonthlyInstanceRefundBill
        /// - MonthlyAddAdjustInvoce
        /// - MonthlyRefundAdjustInvoce 
        /// - MonthlyInstanceConsumeV2 
        /// - MarginReportV2
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// Billing Month, Format is YYYY-MM
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

    }

}
