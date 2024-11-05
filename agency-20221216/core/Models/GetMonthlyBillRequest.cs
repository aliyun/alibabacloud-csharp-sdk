// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillRequest : TeaModel {
        /// <summary>
        /// <para>Bill Owner type. Value Range:</br>
        /// 1: Master account</br>
        /// 2: Sub account</br></para>
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
        /// <list type="bullet">
        /// <item><description>MonthlyInvoice</description></item>
        /// <item><description>MonthRefundInvoice</description></item>
        /// <item><description>MonthlySummary</description></item>
        /// <item><description>MonthlyInstanceAddAdjustBill </description></item>
        /// <item><description>MonthlyInstanceRefundBill</description></item>
        /// <item><description>MonthlyAddAdjustInvoce</description></item>
        /// <item><description>MonthlyRefundAdjustInvoce </description></item>
        /// <item><description>MonthlyInstanceConsumeV2 </description></item>
        /// <item><description>MarginReportV2</description></item>
        /// </list>
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
