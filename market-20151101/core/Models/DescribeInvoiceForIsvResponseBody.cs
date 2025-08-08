// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInvoiceForIsvResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3v3mzZN1QdVsTPNiT0OkD36LC9I+AJHU9z2oXBmJJOyy4nQl7MIUZUYG6fdbYBk+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeInvoiceForIsvResponseBodyResult> Result { get; set; }
        public class DescribeInvoiceForIsvResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>102277855749****</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            [NameInMap("CreateTimeStr")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            [NameInMap("EvaluateList")]
            [Validation(Required=false)]
            public List<DescribeInvoiceForIsvResponseBodyResultEvaluateList> EvaluateList { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultEvaluateList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public bool? Agent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("BizTimeStr")]
                [Validation(Required=false)]
                public string BizTimeStr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9540765</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024091610072000****</para>
                /// </summary>
                [NameInMap("OutBizId")]
                [Validation(Required=false)]
                public string OutBizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>102277855749****</para>
                /// </summary>
                [NameInMap("RealAliyunPk")]
                [Validation(Required=false)]
                public string RealAliyunPk { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>58050005</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InvoiceId")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            [NameInMap("InvoiceList")]
            [Validation(Required=false)]
            public List<DescribeInvoiceForIsvResponseBodyResultInvoiceList> InvoiceList { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultInvoiceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50000018</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99.99</para>
                /// </summary>
                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaterialType")]
            [Validation(Required=false)]
            public string MaterialType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-03-04T09:43:18+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("ModifiedTimeStr")]
            [Validation(Required=false)]
            public string ModifiedTimeStr { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99.99</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("ReceiptUserInfoDto")]
            [Validation(Required=false)]
            public DescribeInvoiceForIsvResponseBodyResultReceiptUserInfoDto ReceiptUserInfoDto { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultReceiptUserInfoDto : TeaModel {
                [NameInMap("TaxNumber")]
                [Validation(Required=false)]
                public string TaxNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UserAddressDto")]
            [Validation(Required=false)]
            public DescribeInvoiceForIsvResponseBodyResultUserAddressDto UserAddressDto { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultUserAddressDto : TeaModel {
                [NameInMap("Addressee")]
                [Validation(Required=false)]
                public string Addressee { get; set; }

                [NameInMap("AliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("DeliveryAddress")]
                [Validation(Required=false)]
                public string DeliveryAddress { get; set; }

                [NameInMap("Emails")]
                [Validation(Required=false)]
                public string Emails { get; set; }

                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
