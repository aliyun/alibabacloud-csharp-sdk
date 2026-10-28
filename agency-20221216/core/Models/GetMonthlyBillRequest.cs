// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillRequest : TeaModel {
        /// <summary>
        /// <para>Bill Owner type.</para>
        /// <para> Value range:</para>
        /// <para>1: Master account </para>
        /// <para>2: Sub account</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BillOwner")]
        [Validation(Required=false)]
        public string BillOwner { get; set; }

        /// <summary>
        /// <para>Value Range:</para>
        /// <para>MonthlyInvoice</para>
        /// <para>MonthRefundInvoice</para>
        /// <para>MonthlySummary (Deprecated)</para>
        /// <para>MonthlyInstanceAddAdjustBill </para>
        /// <para>MonthlyInstanceRefundBill</para>
        /// <para>MonthlyAddAdjustInvoce</para>
        /// <para>MonthlyRefundAdjustInvoce </para>
        /// <para>MonthlyInstanceConsumeV2 </para>
        /// <para>MarginReportV2</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MonthlyInvoice</para>
        /// </summary>
        [NameInMap("BillType")]
        [Validation(Required=false)]
        public string BillType { get; set; }

        /// <summary>
        /// <para>Billing Month, Format is YYYY-MM</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11</para>
        /// </summary>
        [NameInMap("Month")]
        [Validation(Required=false)]
        public string Month { get; set; }

    }

}
