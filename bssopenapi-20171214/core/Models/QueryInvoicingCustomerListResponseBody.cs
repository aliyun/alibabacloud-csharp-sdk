// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInvoicingCustomerListResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInvoicingCustomerListResponseBodyData Data { get; set; }
        public class QueryInvoicingCustomerListResponseBodyData : TeaModel {
            /// <summary>
            /// The information about the invoice.
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
                    /// The type of invoice that was changed to.
                    /// </summary>
                    [NameInMap("AdjustType")]
                    [Validation(Required=false)]
                    public long? AdjustType { get; set; }

                    /// <summary>
                    /// The bank that issues the invoice.
                    /// </summary>
                    [NameInMap("Bank")]
                    [Validation(Required=false)]
                    public string Bank { get; set; }

                    /// <summary>
                    /// The bank account number.
                    /// </summary>
                    [NameInMap("BankNo")]
                    [Validation(Required=false)]
                    public string BankNo { get; set; }

                    /// <summary>
                    /// The authentication type of Alipay. Valid values:
                    /// 
                    /// *   1: individual
                    /// *   2: company
                    /// </summary>
                    [NameInMap("CustomerType")]
                    [Validation(Required=false)]
                    public long? CustomerType { get; set; }

                    /// <summary>
                    /// The default note that is attached when the title is specified.
                    /// </summary>
                    [NameInMap("DefaultRemark")]
                    [Validation(Required=false)]
                    public string DefaultRemark { get; set; }

                    /// <summary>
                    /// The time when the payment ended.
                    /// </summary>
                    [NameInMap("EndCycle")]
                    [Validation(Required=false)]
                    public long? EndCycle { get; set; }

                    /// <summary>
                    /// The time when the invoice was created. The time was in the yyyy-mm-dd hh:mm:ss format.
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// The ID of the invoice.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The company name in the invoice title.
                    /// </summary>
                    [NameInMap("InvoiceTitle")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    /// <summary>
                    /// The type of issue.
                    /// </summary>
                    [NameInMap("IssueType")]
                    [Validation(Required=false)]
                    public long? IssueType { get; set; }

                    /// <summary>
                    /// The address of the business license.
                    /// </summary>
                    [NameInMap("OperatingLicenseAddress")]
                    [Validation(Required=false)]
                    public string OperatingLicenseAddress { get; set; }

                    /// <summary>
                    /// The phone number of the business license.
                    /// </summary>
                    [NameInMap("OperatingLicensePhone")]
                    [Validation(Required=false)]
                    public string OperatingLicensePhone { get; set; }

                    /// <summary>
                    /// The tax registration number.
                    /// </summary>
                    [NameInMap("RegisterNo")]
                    [Validation(Required=false)]
                    public string RegisterNo { get; set; }

                    /// <summary>
                    /// The time when the payment started.
                    /// </summary>
                    [NameInMap("StartCycle")]
                    [Validation(Required=false)]
                    public long? StartCycle { get; set; }

                    /// <summary>
                    /// The status of the invoice title.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// The path and file name of the scanned copy of the tax registration certificate.
                    /// </summary>
                    [NameInMap("TaxationLicense")]
                    [Validation(Required=false)]
                    public string TaxationLicense { get; set; }

                    /// <summary>
                    /// The type of the taxpayer. Valid values:
                    /// 
                    /// *   1: general taxpayer
                    /// *   2: special taxpayer
                    /// </summary>
                    [NameInMap("TaxpayerType")]
                    [Validation(Required=false)]
                    public long? TaxpayerType { get; set; }

                    /// <summary>
                    /// The instruction document of the invoice title change.
                    /// </summary>
                    [NameInMap("TitleChangeInstructions")]
                    [Validation(Required=false)]
                    public string TitleChangeInstructions { get; set; }

                    /// <summary>
                    /// The type of the invoice. Valid values:
                    /// 
                    /// *   0: plain value-added tax (VAT) invoice
                    /// *   1: special VAT invoice
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                    /// <summary>
                    /// The ID of the user.
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    /// <summary>
                    /// The nickname of the user.
                    /// </summary>
                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
