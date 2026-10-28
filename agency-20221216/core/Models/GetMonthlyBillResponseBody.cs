// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetMonthlyBillResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>200: OK.</description></item>
        /// <item><description>1109: A system error occurred.</description></item>
        /// <item><description>3030: The account nickname exceeds the maximum length of 150 bytes.</description></item>
        /// <item><description>3031: The remark exceeds the maximum length of 3,000 bytes.</description></item>
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
            /// <para>The URL used to download the CSV file. Use the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkCSV")]
            [Validation(Required=false)]
            public string BillLinkCSV { get; set; }

            /// <summary>
            /// <para>The URL used to download the XLSX file. Use the HTTP protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("BillLinkXLSX")]
            [Validation(Required=false)]
            public string BillLinkXLSX { get; set; }

            /// <summary>
            /// <para>The bill owner, which is the same as the value of the BillOwner request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BillOwner")]
            [Validation(Required=false)]
            public string BillOwner { get; set; }

            /// <summary>
            /// <para>The bill type, which is the same as the value of the BillType request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MonthlyInvoice</para>
            /// </summary>
            [NameInMap("BillType")]
            [Validation(Required=false)]
            public string BillType { get; set; }

            /// <summary>
            /// <para>The URL used to download the invoice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("InvoiceLink")]
            [Validation(Required=false)]
            public string InvoiceLink { get; set; }

            /// <summary>
            /// <para>Specifies whether a refund invoice exists. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True: A refund invoice exists.</description></item>
            /// <item><description>False: No refund invoice exists.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("RefundInvoiceFlag")]
            [Validation(Required=false)]
            public bool? RefundInvoiceFlag { get; set; }

            /// <summary>
            /// <para>The URL used to download the refund invoice.</para>
            /// 
            /// <b>Example:</b>
            /// <para>intl-reseller-month-bill.oss-ap-southeast-1.aliyuncs.com/statements/month/dts/1064252248461886/202104/Month%20Billing%20Invoice%20202104.pdf?Expires=1671160973&amp;OSSAccessKeyId=TMP.3KhvoD9pW264cPv8sYe8E2zJ5HLWmrijNHgKiKpXcy8yS472BcrvemgTfNrrXKu5fCCdbLr2XhmYAyYPmbCe8zJyEkmYzL&amp;Signature=hns1PgiiYl1WdI%2FdiOqbEdsgmfI%3D</para>
            /// </summary>
            [NameInMap("RefundInvoiceLink")]
            [Validation(Required=false)]
            public string RefundInvoiceLink { get; set; }

            /// <summary>
            /// <para>The consumption time in the YYYYMMDD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20221201</para>
            /// </summary>
            [NameInMap("SpendingTime")]
            [Validation(Required=false)]
            public string SpendingTime { get; set; }

        }

        /// <summary>
        /// <para>The message corresponding to the value of the Code parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e876f16704666020714468dab35</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the current API call is successful. This indicates only the success of the API call itself, not the success of subsequent business operations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: The API call is successful.</description></item>
        /// <item><description>False: The API call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
