// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListSupplierRegistrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdx9kBO7qKpr9My/+XQo0oY=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6CC568D-xxxx-xxxx-xxxx-08EB8E9F9F20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The supplier registrations</para>
        /// </summary>
        [NameInMap("SupplierRegistrations")]
        [Validation(Required=false)]
        public List<ListSupplierRegistrationsResponseBodySupplierRegistrations> SupplierRegistrations { get; set; }
        public class ListSupplierRegistrationsResponseBodySupplierRegistrations : TeaModel {
            /// <summary>
            /// <para>The comment of this registration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Contact email</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@163.com">test@163.com</a></para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>Contact number</para>
            /// 
            /// <b>Example:</b>
            /// <para>135xxxxxxxx</para>
            /// </summary>
            [NameInMap("ContactNumber")]
            [Validation(Required=false)]
            public string ContactNumber { get; set; }

            /// <summary>
            /// <para>Contact person</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mike</para>
            /// </summary>
            [NameInMap("ContactPerson")]
            [Validation(Required=false)]
            public string ContactPerson { get; set; }

            /// <summary>
            /// <para>Contact person tiltle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CTO</para>
            /// </summary>
            [NameInMap("ContactPersonTitle")]
            [Validation(Required=false)]
            public string ContactPersonTitle { get; set; }

            /// <summary>
            /// <para>Whether to enable the resell mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableResellerMode")]
            [Validation(Required=false)]
            public bool? EnableResellerMode { get; set; }

            /// <summary>
            /// <para>Annual product revenue</para>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("ProductAnnualRevenue")]
            [Validation(Required=false)]
            public string ProductAnnualRevenue { get; set; }

            /// <summary>
            /// <para>The business of product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("ProductBusiness")]
            [Validation(Required=false)]
            public string ProductBusiness { get; set; }

            /// <summary>
            /// <para>Product delivery type，Valid values:</para>
            /// <para>SaaS
            /// License
            /// API
            /// DesktopSoftware
            /// Others</para>
            /// 
            /// <b>Example:</b>
            /// <para>SaaS</para>
            /// </summary>
            [NameInMap("ProductDeliveryTypes")]
            [Validation(Required=false)]
            public string ProductDeliveryTypes { get; set; }

            /// <summary>
            /// <para>The publish time of product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024.10.24</para>
            /// </summary>
            [NameInMap("ProductPublishTime")]
            [Validation(Required=false)]
            public string ProductPublishTime { get; set; }

            /// <summary>
            /// <para>Product sell type, Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Direct</description></item>
            /// <item><description>Channel</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Direct</para>
            /// </summary>
            [NameInMap("ProductSellTypes")]
            [Validation(Required=false)]
            public string ProductSellTypes { get; set; }

            /// <summary>
            /// <para>The registration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sr-xxx</para>
            /// </summary>
            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            /// <summary>
            /// <para>The description of resell business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>empty</para>
            /// </summary>
            [NameInMap("ResellBusinessDesc")]
            [Validation(Required=false)]
            public string ResellBusinessDesc { get; set; }

            /// <summary>
            /// <para>The deployment state of the registration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Submitted</description></item>
            /// <item><description>Approved</description></item>
            /// <item><description>Rejected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Submitted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The submit time of this registration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-22 09:47:58</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The description of service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test supplier</para>
            /// </summary>
            [NameInMap("SupplierDesc")]
            [Validation(Required=false)]
            public string SupplierDesc { get; set; }

            /// <summary>
            /// <para>The Logo of service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://service-info-public.oss-cn-hangzhou.aliyuncs.com/xxx/service-xxx/xxx.png">https://service-info-public.oss-cn-hangzhou.aliyuncs.com/xxx/service-xxx/xxx.png</a></para>
            /// </summary>
            [NameInMap("SupplierLogo")]
            [Validation(Required=false)]
            public string SupplierLogo { get; set; }

            /// <summary>
            /// <para>The name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Aliibaba Cloud</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The english name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud ComputeNest</para>
            /// </summary>
            [NameInMap("SupplierNameEn")]
            [Validation(Required=false)]
            public string SupplierNameEn { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1256xxx23434</para>
            /// </summary>
            [NameInMap("SupplierUid")]
            [Validation(Required=false)]
            public string SupplierUid { get; set; }

            /// <summary>
            /// <para>The URL of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.guangbao-uni.com">https://www.guangbao-uni.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
