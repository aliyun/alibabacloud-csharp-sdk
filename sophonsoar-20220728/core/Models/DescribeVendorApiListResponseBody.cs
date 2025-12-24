// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeVendorApiListResponseBody : TeaModel {
        /// <summary>
        /// <para>Product information.</para>
        /// </summary>
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<DescribeVendorApiListResponseBodyApiList> ApiList { get; set; }
        public class DescribeVendorApiListResponseBodyApiList : TeaModel {
            /// <summary>
            /// <para>Advanced configuration for the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;cmd&quot;: &quot;DescribeAclApiDispatch&quot;
            /// }</para>
            /// </summary>
            [NameInMap("AdvanceConfig")]
            [Validation(Required=false)]
            public string AdvanceConfig { get; set; }

            /// <summary>
            /// <para>The name of the vendor\&quot;s API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VerifyMobile</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The version number of the API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-08-01</para>
            /// </summary>
            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <para>Request methods: </para>
            /// <list type="bullet">
            /// <item><description><b>POST</b>: POST request method. </description></item>
            /// <item><description><b>GET</b>: GET request method. </description></item>
            /// <item><description><b>PUT</b>: PUT request method. </description></item>
            /// <item><description><b>DELETE</b>: DELETE request method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <para>Indicates whether advanced configuration is included.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAdvanceConfig")]
            [Validation(Required=false)]
            public bool? NeedAdvanceConfig { get; set; }

            /// <summary>
            /// <para>Indicates whether pagination is needed.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedPageInfo")]
            [Validation(Required=false)]
            public bool? NeedPageInfo { get; set; }

            /// <summary>
            /// <para>Information displayed on the page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Count\&quot;: 10, \&quot;TotalCount\&quot;: 23, \&quot;PageSize\&quot;: 10, \&quot;CurrentPage\&quot;: 1}</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public string PageInfo { get; set; }

            /// <summary>
            /// <para>Interface request parameter configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;name&quot;: &quot;Domain&quot;,
            ///         &quot;type&quot;: &quot;String&quot;,
            ///         &quot;isRequired&quot;: true,
            ///         &quot;exampleValue&quot;: &quot;www.<em><b>.com&quot;,
            ///         &quot;description&quot;: &quot;www.</b></em>.com&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("Parameter")]
            [Validation(Required=false)]
            public string Parameter { get; set; }

            /// <summary>
            /// <para>Vendor\&quot;s product identifier:</para>
            /// <list type="bullet">
            /// <item><description><b>waf</b>: Web Application Firewall.</description></item>
            /// <item><description><b>cfw</b>: Cloud Firewall.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cfw</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>Default domain of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfw.xxx.com</para>
            /// </summary>
            [NameInMap("ProductDomain")]
            [Validation(Required=false)]
            public string ProductDomain { get; set; }

            /// <summary>
            /// <para>Product name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Request protocol. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>http</b>: HTTP request protocol.</description></item>
            /// <item><description><b>https</b>: HTTPS request protocol.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>https</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Vendor code:</para>
            /// <list type="bullet">
            /// <item><description><b>Tencent</b>: Tencent.</description></item>
            /// <item><description><b>HUAWEICLOUD</b>: Huawei.</description></item>
            /// <item><description><b>Azure</b>: Microsoft Azure.</description></item>
            /// <item><description><b>AWS</b>: Amazon Web Services.</description></item>
            /// <item><description><b>Chaitin</b>: Chaitin.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Azure</para>
            /// </summary>
            [NameInMap("VendorCode")]
            [Validation(Required=false)]
            public string VendorCode { get; set; }

        }

        /// <summary>
        /// <para>Pagination query information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeVendorApiListResponseBodyPage Page { get; set; }
        public class DescribeVendorApiListResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The current page number in the pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of items displayed per page in the pagination query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request, and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7698CFB-****-5840-8EC9-691B86729E94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
