// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListInvoiceCandidateResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of data entries.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInvoiceCandidateResponseBodyData> Data { get; set; }
        public class ListInvoiceCandidateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The accepted offset amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("AcceptedOffsetAmount")]
            [Validation(Required=false)]
            public string AcceptedOffsetAmount { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试账号</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The billing cycle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202506</para>
            /// </summary>
            [NameInMap("BillingCycle")]
            [Validation(Required=false)]
            public int? BillingCycle { get; set; }

            /// <summary>
            /// <para>The business document number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202506</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <para>The time when the business event occurred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-01 00:00:00</para>
            /// </summary>
            [NameInMap("BusinessTime")]
            [Validation(Required=false)]
            public string BusinessTime { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The commodity name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>性能测试</para>
            /// </summary>
            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-91 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the invoice candidate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The invoice issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN_SERVICE</para>
            /// </summary>
            [NameInMap("InvoiceIssuer")]
            [Validation(Required=false)]
            public string InvoiceIssuer { get; set; }

            /// <summary>
            /// <para>The invoiceable amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("InvoiceableAmount")]
            [Validation(Required=false)]
            public string InvoiceableAmount { get; set; }

            /// <summary>
            /// <para>The invoiced amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InvoicedAmount")]
            [Validation(Required=false)]
            public string InvoicedAmount { get; set; }

            /// <summary>
            /// <para>The offset amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OffsetAmount")]
            [Validation(Required=false)]
            public string OffsetAmount { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>性能测试</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The ID of the resource owner account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountId")]
            [Validation(Required=false)]
            public long? ResourceOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The name of the resource owner account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试账号</para>
            /// </summary>
            [NameInMap("ResourceOwnerAccountName")]
            [Validation(Required=false)]
            public string ResourceOwnerAccountName { get; set; }

            /// <summary>
            /// <para>The status of the invoice candidate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The total amount.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.01</para>
            /// </summary>
            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }

            /// <summary>
            /// <para>The type of the invoice candidate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The metadata of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
