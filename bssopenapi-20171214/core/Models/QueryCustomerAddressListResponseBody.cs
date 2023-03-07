// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCustomerAddressListResponseBody : TeaModel {
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
        public QueryCustomerAddressListResponseBodyData Data { get; set; }
        public class QueryCustomerAddressListResponseBodyData : TeaModel {
            /// <summary>
            /// The details of addresses to which invoices are mailed.
            /// </summary>
            [NameInMap("CustomerInvoiceAddressList")]
            [Validation(Required=false)]
            public QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressList CustomerInvoiceAddressList { get; set; }
            public class QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressList : TeaModel {
                [NameInMap("CustomerInvoiceAddress")]
                [Validation(Required=false)]
                public List<QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressListCustomerInvoiceAddress> CustomerInvoiceAddress { get; set; }
                public class QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressListCustomerInvoiceAddress : TeaModel {
                    /// <summary>
                    /// The addressee.
                    /// </summary>
                    [NameInMap("Addressee")]
                    [Validation(Required=false)]
                    public string Addressee { get; set; }

                    /// <summary>
                    /// The business type.
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// The city to which the invoice is mailed.
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// The name of the district to which the invoice is mailed.
                    /// </summary>
                    [NameInMap("County")]
                    [Validation(Required=false)]
                    public string County { get; set; }

                    /// <summary>
                    /// The detailed address to which the invoice is mailed. This parameter is returned after fields are concatenated.
                    /// </summary>
                    [NameInMap("DeliveryAddress")]
                    [Validation(Required=false)]
                    public string DeliveryAddress { get; set; }

                    /// <summary>
                    /// The ID.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The phone number of the addressee.
                    /// </summary>
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    /// <summary>
                    /// The postcode.
                    /// </summary>
                    [NameInMap("PostalCode")]
                    [Validation(Required=false)]
                    public string PostalCode { get; set; }

                    /// <summary>
                    /// The province to which the invoice is mailed.
                    /// </summary>
                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    /// <summary>
                    /// The name of the street to which the invoice is mailed.
                    /// </summary>
                    [NameInMap("Street")]
                    [Validation(Required=false)]
                    public string Street { get; set; }

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
