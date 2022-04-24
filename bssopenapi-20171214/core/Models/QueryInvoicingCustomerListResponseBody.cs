// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryInvoicingCustomerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInvoicingCustomerListResponseBodyData Data { get; set; }
        public class QueryInvoicingCustomerListResponseBodyData : TeaModel {
            [NameInMap("CustomerInvoiceList")]
            [Validation(Required=false)]
            public QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceList CustomerInvoiceList { get; set; }
            public class QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceList : TeaModel {
                [NameInMap("CustomerInvoice")]
                [Validation(Required=false)]
                public List<QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceListCustomerInvoice> CustomerInvoice { get; set; }
                public class QueryInvoicingCustomerListResponseBodyDataCustomerInvoiceListCustomerInvoice : TeaModel {
                    [NameInMap("AdjustType")]
                    [Validation(Required=false)]
                    public long? AdjustType { get; set; }

                    [NameInMap("Bank")]
                    [Validation(Required=false)]
                    public string Bank { get; set; }

                    [NameInMap("BankNo")]
                    [Validation(Required=false)]
                    public string BankNo { get; set; }

                    [NameInMap("CustomerType")]
                    [Validation(Required=false)]
                    public long? CustomerType { get; set; }

                    [NameInMap("DefaultRemark")]
                    [Validation(Required=false)]
                    public string DefaultRemark { get; set; }

                    [NameInMap("EndCycle")]
                    [Validation(Required=false)]
                    public long? EndCycle { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("InvoiceTitle")]
                    [Validation(Required=false)]
                    public string InvoiceTitle { get; set; }

                    [NameInMap("IssueType")]
                    [Validation(Required=false)]
                    public long? IssueType { get; set; }

                    [NameInMap("OperatingLicenseAddress")]
                    [Validation(Required=false)]
                    public string OperatingLicenseAddress { get; set; }

                    [NameInMap("OperatingLicensePhone")]
                    [Validation(Required=false)]
                    public string OperatingLicensePhone { get; set; }

                    [NameInMap("RegisterNo")]
                    [Validation(Required=false)]
                    public string RegisterNo { get; set; }

                    [NameInMap("StartCycle")]
                    [Validation(Required=false)]
                    public long? StartCycle { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    [NameInMap("TaxationLicense")]
                    [Validation(Required=false)]
                    public string TaxationLicense { get; set; }

                    [NameInMap("TaxpayerType")]
                    [Validation(Required=false)]
                    public long? TaxpayerType { get; set; }

                    [NameInMap("TitleChangeInstructions")]
                    [Validation(Required=false)]
                    public string TitleChangeInstructions { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
