// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListSupplierRegistrationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
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
        /// <para>A list of service provider registration requests.</para>
        /// </summary>
        [NameInMap("SupplierRegistrations")]
        [Validation(Required=false)]
        public List<ListSupplierRegistrationsResponseBodySupplierRegistrations> SupplierRegistrations { get; set; }
        public class ListSupplierRegistrationsResponseBodySupplierRegistrations : TeaModel {
            /// <summary>
            /// <para>The review comments.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The email address of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@163.com">test@163.com</a></para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The phone number of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135xxxxxxxx</para>
            /// </summary>
            [NameInMap("ContactNumber")]
            [Validation(Required=false)]
            public string ContactNumber { get; set; }

            /// <summary>
            /// <para>The contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Doe</para>
            /// </summary>
            [NameInMap("ContactPerson")]
            [Validation(Required=false)]
            public string ContactPerson { get; set; }

            /// <summary>
            /// <para>The title of the contact person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CTO</para>
            /// </summary>
            [NameInMap("ContactPersonTitle")]
            [Validation(Required=false)]
            public string ContactPersonTitle { get; set; }

            /// <summary>
            /// <para>Indicates whether the reseller mode is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableResellerMode")]
            [Validation(Required=false)]
            public bool? EnableResellerMode { get; set; }

            /// <summary>
            /// <para>The annual revenue of the service provider\&quot;s product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000000</para>
            /// </summary>
            [NameInMap("ProductAnnualRevenue")]
            [Validation(Required=false)]
            public string ProductAnnualRevenue { get; set; }

            /// <summary>
            /// <para>The industry of the service provider\&quot;s product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("ProductBusiness")]
            [Validation(Required=false)]
            public string ProductBusiness { get; set; }

            /// <summary>
            /// <para>The delivery method of the service provider\&quot;s product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SaaS</para>
            /// </description></item>
            /// <item><description><para>License</para>
            /// </description></item>
            /// <item><description><para>API</para>
            /// </description></item>
            /// <item><description><para>Desktop software</para>
            /// </description></item>
            /// <item><description><para>Other</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SaaS</para>
            /// </summary>
            [NameInMap("ProductDeliveryTypes")]
            [Validation(Required=false)]
            public string ProductDeliveryTypes { get; set; }

            /// <summary>
            /// <para>The product launch date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024.10.24</para>
            /// </summary>
            [NameInMap("ProductPublishTime")]
            [Validation(Required=false)]
            public string ProductPublishTime { get; set; }

            /// <summary>
            /// <para>The sales model of the service provider\&quot;s product. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Direct</para>
            /// </description></item>
            /// <item><description><para>Channel</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>直销</para>
            /// </summary>
            [NameInMap("ProductSellTypes")]
            [Validation(Required=false)]
            public string ProductSellTypes { get; set; }

            /// <summary>
            /// <para>The ID of the review request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sr-xxx</para>
            /// </summary>
            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            /// <summary>
            /// <para>The description of the reseller business.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("ResellBusinessDesc")]
            [Validation(Required=false)]
            public string ResellBusinessDesc { get; set; }

            /// <summary>
            /// <para>The review status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Submitted: The request is submitted.</para>
            /// </description></item>
            /// <item><description><para>Approved: The request is approved.</para>
            /// </description></item>
            /// <item><description><para>Rejected: The request is rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Submitted</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the request was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-22 09:47:58</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The description of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>服务商测试申请</para>
            /// </summary>
            [NameInMap("SupplierDesc")]
            [Validation(Required=false)]
            public string SupplierDesc { get; set; }

            /// <summary>
            /// <para>The icon of the service provider.</para>
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
            /// <para>ComputeNest community service</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The English name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud ComputeNest</para>
            /// </summary>
            [NameInMap("SupplierNameEn")]
            [Validation(Required=false)]
            public string SupplierNameEn { get; set; }

            /// <summary>
            /// <para>The UID of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1256xxx23434</para>
            /// </summary>
            [NameInMap("SupplierUid")]
            [Validation(Required=false)]
            public string SupplierUid { get; set; }

            /// <summary>
            /// <para>The URL of the service provider\&quot;s official website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.guangbao-uni.com">https://www.guangbao-uni.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
