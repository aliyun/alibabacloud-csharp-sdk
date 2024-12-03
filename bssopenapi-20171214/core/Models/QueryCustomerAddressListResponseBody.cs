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
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCustomerAddressListResponseBodyData Data { get; set; }
        public class QueryCustomerAddressListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of addresses to which invoices are mailed.</para>
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
                    /// <para>The addressee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Addressee")]
                    [Validation(Required=false)]
                    public string Addressee { get; set; }

                    /// <summary>
                    /// <para>The business type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// <para>The city to which the invoice is mailed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hangzhou</para>
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// <para>The name of the district to which the invoice is mailed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test District</para>
                    /// </summary>
                    [NameInMap("County")]
                    [Validation(Required=false)]
                    public string County { get; set; }

                    /// <summary>
                    /// <para>The detailed address to which the invoice is mailed. This parameter is returned after fields are concatenated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Address</para>
                    /// </summary>
                    [NameInMap("DeliveryAddress")]
                    [Validation(Required=false)]
                    public string DeliveryAddress { get; set; }

                    /// <summary>
                    /// <para>The ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>311601051</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The phone number of the addressee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>138xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                    /// <summary>
                    /// <para>The postcode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>000000</para>
                    /// </summary>
                    [NameInMap("PostalCode")]
                    [Validation(Required=false)]
                    public string PostalCode { get; set; }

                    /// <summary>
                    /// <para>The province to which the invoice is mailed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zhejiang</para>
                    /// </summary>
                    [NameInMap("Province")]
                    [Validation(Required=false)]
                    public string Province { get; set; }

                    /// <summary>
                    /// <para>The name of the street to which the invoice is mailed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Test Street</para>
                    /// </summary>
                    [NameInMap("Street")]
                    [Validation(Required=false)]
                    public string Street { get; set; }

                    /// <summary>
                    /// <para>The ID of the user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4382956342857</para>
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
