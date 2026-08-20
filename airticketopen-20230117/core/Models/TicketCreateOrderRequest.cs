// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class TicketCreateOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public TicketCreateOrderRequestContact Contact { get; set; }
        public class TicketCreateOrderRequestContact : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>11010519900301001X</para>
            /// </summary>
            [NameInMap("CertificateNo")]
            [Validation(Required=false)]
            public string CertificateNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public int? CertificateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("DialingCode")]
            [Validation(Required=false)]
            public string DialingCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example.com">test@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZHANG</para>
            /// </summary>
            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SAN</para>
            /// </summary>
            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13800000000</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DistributorOrderId")]
        [Validation(Required=false)]
        public string DistributorOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderProduct")]
        [Validation(Required=false)]
        public TicketCreateOrderRequestOrderProduct OrderProduct { get; set; }
        public class TicketCreateOrderRequestOrderProduct : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DistributionPrice")]
            [Validation(Required=false)]
            public TicketCreateOrderRequestOrderProductDistributionPrice DistributionPrice { get; set; }
            public class TicketCreateOrderRequestOrderProductDistributionPrice : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("CurrencyCode")]
                [Validation(Required=false)]
                public string CurrencyCode { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-01</para>
            /// </summary>
            [NameInMap("TravelDate")]
            [Validation(Required=false)]
            public string TravelDate { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TotalDistributionPrice")]
        [Validation(Required=false)]
        public TicketCreateOrderRequestTotalDistributionPrice TotalDistributionPrice { get; set; }
        public class TicketCreateOrderRequestTotalDistributionPrice : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("CurrencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

        }

        [NameInMap("Travelers")]
        [Validation(Required=false)]
        public List<TicketCreateOrderRequestTravelers> Travelers { get; set; }
        public class TicketCreateOrderRequestTravelers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1990-01-01</para>
            /// </summary>
            [NameInMap("Birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("CertificateNo")]
            [Validation(Required=false)]
            public string CertificateNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CertificateType")]
            [Validation(Required=false)]
            public int? CertificateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86</para>
            /// </summary>
            [NameInMap("DialingCode")]
            [Validation(Required=false)]
            public string DialingCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:example@example.com">example@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Zhang</para>
            /// </summary>
            [NameInMap("FirstName")]
            [Validation(Required=false)]
            public string FirstName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>San</para>
            /// </summary>
            [NameInMap("LastName")]
            [Validation(Required=false)]
            public string LastName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13800000000</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

        }

    }

}
