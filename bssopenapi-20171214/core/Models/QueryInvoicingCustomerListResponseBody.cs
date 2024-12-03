// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInvoicingCustomerListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInvoicingCustomerListResponseBodyData Data { get; set; }
        public class QueryInvoicingCustomerListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the invoice.</para>
            /// </summary>
            [NameInMap("CustomerInvoiceList")]
            [Validation(Required=false)]
            public QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceList CustomerInvoiceList { get; set; }
            public class QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceList : TeaModel {
                [NameInMap("CustomerInvoice")]
                [Validation(Required=false)]
                public List<QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceListCustomerInvoice> CustomerInvoice { get; set; }
                public class QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceListCustomerInvoice : TeaModel {
                    /// <summary>
                    /// <para>The type of invoice that was changed to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AdjustType")]
                    [Validation(Required=false)]
                    public long? AdjustType { get; set; }

                    /// <summary>
                    /// <para>The bank that issues the invoice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Bank</para>
                    /// </summary>
                    [NameInMap("Bank")]
                    [Validation(Required=false)]
                    public string Bank { get; set; }

                    /// <summary>
                    /// <para>The bank account number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>389576348573296349853476</para>
                    /// </summary>
                    [NameInMap("BankNo")]
                    [Validation(Required=false)]
                    public string BankNo { get; set; }

                    /// <summary>
                    /// <para>The authentication type of Alipay. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: individual</description></item>
                    /// <item><description>2: company</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CustomerType")]
                    [Validation(Required=false)]
                    public long? CustomerType { get; set; }

                    /// <summary>
                    /// <para>The default note that is attached when the title is specified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PO Code: 12984554</para>
                    /// </summary>
                    [NameInMap("DefaultRemark")]
                    [Validation(Required=false)]
                    public string DefaultRemark { get; set; }

                    /// <summary>
                    /// <para>The time when the payment ended.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>202003</para>
                    /// </summary>
                    [NameInMap("EndCycle")]
                    [Validation(Required=false)]
                    public long? EndCycle { get; set; }

                    /// <summary>
                    /// <para>The time when the invoice was created. The time was in the yyyy-mm-dd hh:mm:ss format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-09-07 15:26:20</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The ID of the invoice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>239875502738</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The company name in the invoice title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Company</para>
                    /// </summary>
                    [NameInMap("InvoiceTitle")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// <para>The type of issue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IssueType")]
                    [Validation(Required=false)]
                    public long? IssueType { get; set; }

                    /// <summary>
                    /// <para>The address of the business license.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XXX, XXX district, XXX city, XXX province</para>
                    /// </summary>
                    [NameInMap("OperatingLicenseAddress")]
                    [Validation(Required=false)]
                    public string OperatingLicenseAddress { get; set; }

                    /// <summary>
                    /// <para>The phone number of the business license.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>138xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("OperatingLicensePhone")]
                    [Validation(Required=false)]
                    public string OperatingLicensePhone { get; set; }

                    /// <summary>
                    /// <para>The tax registration number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>21343245342534</para>
                    /// </summary>
                    [NameInMap("RegisterNo")]
                    [Validation(Required=false)]
                    public string RegisterNo { get; set; }

                    /// <summary>
                    /// <para>The time when the payment started.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>202002</para>
                    /// </summary>
                    [NameInMap("StartCycle")]
                    [Validation(Required=false)]
                    public long? StartCycle { get; set; }

                    /// <summary>
                    /// <para>The status of the invoice title.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>The path and file name of the scanned copy of the tax registration certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>taxationLicense.jpg</para>
                    /// </summary>
                    [NameInMap("TaxationLicense")]
                    [Validation(Required=false)]
                    public string TaxationLicense { get; set; }

                    /// <summary>
                    /// <para>The type of the taxpayer. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: general taxpayer</description></item>
                    /// <item><description>2: special taxpayer</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TaxpayerType")]
                    [Validation(Required=false)]
                    public long? TaxpayerType { get; set; }

                    /// <summary>
                    /// <para>The instruction document of the invoice title change.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>instruction.doc</para>
                    /// </summary>
                    [NameInMap("TitleChangeInstructions")]
                    [Validation(Required=false)]
                    public string TitleChangeInstructions { get; set; }

                    /// <summary>
                    /// <para>The type of the invoice. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: plain value-added tax (VAT) invoice</description></item>
                    /// <item><description>1: special VAT invoice</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34565465675</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    /// <summary>
                    /// <para>The nickname of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testNick</para>
                    /// </summary>
                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBEF51A3-E933-4F40-A534-C673CBDB9C80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
