// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInvoiceForIsvResponseBody : TeaModel {
        /// <summary>
        /// <para>The commodity code corresponding to the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Maximum value: 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned by this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3v3mzZN1QdVsTPNiT0OkD36LC9I+AJHU9z2oXBmJJOyy4nQl7MIUZUYG6fdbYBk+</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of instances per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6EF60BEC-0242-43AF-BB20-270359FB54A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The process node information upon success.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeInvoiceForIsvResponseBodyResult> Result { get; set; }
        public class DescribeInvoiceForIsvResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud user ID of the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>102277855749****</para>
            /// </summary>
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// <para>The supplier invoice remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("CheckNotice")]
            [Validation(Required=false)]
            public string CheckNotice { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTimeStr")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            /// <summary>
            /// <para>The order, bill, or contract numbers.</para>
            /// </summary>
            [NameInMap("EvaluateList")]
            [Validation(Required=false)]
            public List<DescribeInvoiceForIsvResponseBodyResultEvaluateList> EvaluateList { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultEvaluateList : TeaModel {
                /// <summary>
                /// <para>Indicates whether invoicing is performed by an agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public bool? Agent { get; set; }

                /// <summary>
                /// <para>The amount. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// <para>The time when the business transaction occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-01 00:00:00</para>
                /// </summary>
                [NameInMap("BizTimeStr")]
                [Validation(Required=false)]
                public string BizTimeStr { get; set; }

                /// <summary>
                /// <para>The invoicing object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9540765</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The order or bill type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>0: order</para>
                /// </description></item>
                /// <item><description><para>1: bill</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OrderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024091610072000****</para>
                /// </summary>
                [NameInMap("OutBizId")]
                [Validation(Required=false)]
                public string OutBizId { get; set; }

                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmapi00067***</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The product name. (Deprecated.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>图像识别OCR***</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:example@alibaba-inc.com">example@alibaba-inc.com</a></para>
                /// </summary>
                [NameInMap("RealAliyunId")]
                [Validation(Required=false)]
                public string RealAliyunId { get; set; }

                /// <summary>
                /// <para>The account to which the order belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102277855749****</para>
                /// </summary>
                [NameInMap("RealAliyunPk")]
                [Validation(Required=false)]
                public string RealAliyunPk { get; set; }

            }

            /// <summary>
            /// <para>The invoice application ID. This corresponds to the InvoiceId parameter used when calling the ModifyInvoiceForIsv operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4072040****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The invoice object ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4072040****</para>
            /// </summary>
            [NameInMap("InvoiceId")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            /// <summary>
            /// <para>The invoice sub-collection. (Deprecated.)</para>
            /// </summary>
            [NameInMap("InvoiceList")]
            [Validation(Required=false)]
            public List<DescribeInvoiceForIsvResponseBodyResultInvoiceList> InvoiceList { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultInvoiceList : TeaModel {
                /// <summary>
                /// <para>The invoice object ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4072040****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The invoicing amount applied for. Unit: CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99.99</para>
                /// </summary>
                [NameInMap("InvoiceAmount")]
                [Validation(Required=false)]
                public string InvoiceAmount { get; set; }

            }

            /// <summary>
            /// <para>The invoice issuance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: paper</description></item>
            /// <item><description>1: electronic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MaterialType")]
            [Validation(Required=false)]
            public string MaterialType { get; set; }

            /// <summary>
            /// <para>The time when the order status was modified (GMT).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-04T09:43:18+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The invoice modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("ModifiedTimeStr")]
            [Validation(Required=false)]
            public string ModifiedTimeStr { get; set; }

            /// <summary>
            /// <para>The total invoice amount. Unit: CNY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99.99</para>
            /// </summary>
            [NameInMap("Price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            /// <summary>
            /// <para>The invoice applicant user information.</para>
            /// </summary>
            [NameInMap("ReceiptUserInfoDto")]
            [Validation(Required=false)]
            public DescribeInvoiceForIsvResponseBodyResultReceiptUserInfoDto ReceiptUserInfoDto { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultReceiptUserInfoDto : TeaModel {
                /// <summary>
                /// <para>The bank account number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>000000</para>
                /// </summary>
                [NameInMap("BankAccount")]
                [Validation(Required=false)]
                public string BankAccount { get; set; }

                /// <summary>
                /// <para>The bank name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("BankName")]
                [Validation(Required=false)]
                public string BankName { get; set; }

                /// <summary>
                /// <para>The registered address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市****</para>
                /// </summary>
                [NameInMap("RegAddress")]
                [Validation(Required=false)]
                public string RegAddress { get; set; }

                /// <summary>
                /// <para>The registered phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-****</para>
                /// </summary>
                [NameInMap("RegPhone")]
                [Validation(Required=false)]
                public string RegPhone { get; set; }

                /// <summary>
                /// <para>The unified social credit code of the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91420100MA49L5****</para>
                /// </summary>
                [NameInMap("TaxNumber")]
                [Validation(Required=false)]
                public string TaxNumber { get; set; }

            }

            /// <summary>
            /// <para>The invoice status. Valid values: 0: pending invoicing. 1: invoiced.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The invoice title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>阿里云计算有限公司</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The invoice type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>2: general digital electronic invoice</description></item>
            /// <item><description>3: special digital electronic invoice</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The address information.</para>
            /// </summary>
            [NameInMap("UserAddressDto")]
            [Validation(Required=false)]
            public DescribeInvoiceForIsvResponseBodyResultUserAddressDto UserAddressDto { get; set; }
            public class DescribeInvoiceForIsvResponseBodyResultUserAddressDto : TeaModel {
                /// <summary>
                /// <para>The recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Addressee")]
                [Validation(Required=false)]
                public string Addressee { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud user ID of the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>174452687724****</para>
                /// </summary>
                [NameInMap("AliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                /// <summary>
                /// <para>Deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The delivery address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市****</para>
                /// </summary>
                [NameInMap("DeliveryAddress")]
                [Validation(Required=false)]
                public string DeliveryAddress { get; set; }

                /// <summary>
                /// <para>The email address.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("Emails")]
                [Validation(Required=false)]
                public string Emails { get; set; }

                /// <summary>
                /// <para>The phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>130********</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The postal code.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("PostalCode")]
                [Validation(Required=false)]
                public string PostalCode { get; set; }

            }

            /// <summary>
            /// <para>The user invoice remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("UserNotice")]
            [Validation(Required=false)]
            public string UserNotice { get; set; }

        }

        /// <summary>
        /// <para>The result indicator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
