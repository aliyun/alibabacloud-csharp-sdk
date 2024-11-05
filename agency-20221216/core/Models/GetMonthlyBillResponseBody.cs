// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillResponseBody : TeaModel {
        /// <summary>
        /// <para>Result Code:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System error</description></item>
        /// <item><description>3030 Sub Account Nickname exceeds maximum length, maximum length 150 bytes.</description></item>
        /// <item><description>3031 Remark exceeds maximum length, maximum length 3000 bytes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMonthlyBillResponseBodyData Data { get; set; }
        public class GetMonthlyBillResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The link to download CSV file, please use HTTP Protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkCSV")]
            [Validation(Required=false)]
            public string BillLinkCSV { get; set; }

            /// <summary>
            /// <para>The link to download XLSX file, please use HTTP Protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkXLSX")]
            [Validation(Required=false)]
            public string BillLinkXLSX { get; set; }

            /// <summary>
            /// <para>Same as inserted parameter BillOwner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BillOwner")]
            [Validation(Required=false)]
            public string BillOwner { get; set; }

            /// <summary>
            /// <para>Same as inserted parameter BillType.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MonthlyInvoice</para>
            /// </summary>
            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            /// <summary>
            /// <para>The URL to download invoice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("InvoiceLink")]
            [Validation(Required=false)]
            public string InvoiceLink { get; set; }

            /// <summary>
            /// <para>It states the existence of refund invoice. </br>
            /// Candidate Values: True/False</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("RefundInvoiceFlag")]
            [Validation(Required=false)]
            public bool? RefundInvoiceFlag { get; set; }

            /// <summary>
            /// <para>The URL to download refund invoice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("RefundInvoiceLink")]
            [Validation(Required=false)]
            public string RefundInvoiceLink { get; set; }

            /// <summary>
            /// <para>Spending Time, refer to the exact time of costuming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20221201</para>
            /// </summary>
            [NameInMap("SpendingTime")]
            [Validation(Required=false)]
            public string SpendingTime { get; set; }

        }

        /// <summary>
        /// <para>Same as Code parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, the unique request identifier generated by Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e876f16704666020714468dab35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
