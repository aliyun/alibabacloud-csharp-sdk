// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCustomerAddressListResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomerAddressListResponseBodyData Data { get; set; }
        public class QueryCustomerAddressListResponseBodyData : TeaModel {
            [NameInMap("CustomerInvoiceAddressList")]
            [Validation(Required=false)]
            public QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressList CustomerInvoiceAddressList { get; set; }
            public class QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressList : TeaModel {
                [NameInMap("CustomerInvoiceAddress")]
                [Validation(Required=false)]
                public List<QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressListCustomerInvoiceAddress> CustomerInvoiceAddress { get; set; }
                public class QueryCustomerAddressListResponseBodyDataCustomerInvoiceAddressListCustomerInvoiceAddress : TeaModel {
                    [NameInMap("Addressee")]
                    [Validation(Required=false)]
                    public string Addressee { get; set; }

                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("County")]
                    [Validation(Required=false)]
                    public string County { get; set; }

                    [NameInMap("DeliveryAddress")]
                    [Validation(Required=false)]
                    public string DeliveryAddress { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    [NameInMap("PostalCode")]
                    [Validation(Required=false)]
                    public string PostalCode { get; set; }

                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    [NameInMap("Street")]
                    [Validation(Required=false)]
                    public string Street { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    [NameInMap("UserNick")]
                    [Validation(Required=false)]
                    public string UserNick { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBEF51A3-E933-4F40-A534-C673CBDB9C80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
