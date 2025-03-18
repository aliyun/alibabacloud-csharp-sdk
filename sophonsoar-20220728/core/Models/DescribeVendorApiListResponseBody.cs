// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeVendorApiListResponseBody : TeaModel {
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<DescribeVendorApiListResponseBodyApiList> ApiList { get; set; }
        public class DescribeVendorApiListResponseBodyApiList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;cmd&quot;: &quot;DescribeAclApiDispatch&quot;
            /// }</para>
            /// </summary>
            [NameInMap("AdvanceConfig")]
            [Validation(Required=false)]
            public string AdvanceConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VerifyMobile</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-08-01</para>
            /// </summary>
            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>POST</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAdvanceConfig")]
            [Validation(Required=false)]
            public bool? NeedAdvanceConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedPageInfo")]
            [Validation(Required=false)]
            public bool? NeedPageInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Count\&quot;: 10, \&quot;TotalCount\&quot;: 23, \&quot;PageSize\&quot;: 10, \&quot;CurrentPage\&quot;: 1}</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public string PageInfo { get; set; }

            /// <summary>
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
            /// <b>Example:</b>
            /// <para>cfw</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cfw.xxx.com</para>
            /// </summary>
            [NameInMap("ProductDomain")]
            [Validation(Required=false)]
            public string ProductDomain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>waf</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Azure</para>
            /// </summary>
            [NameInMap("VendorCode")]
            [Validation(Required=false)]
            public string VendorCode { get; set; }

        }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeVendorApiListResponseBodyPage Page { get; set; }
        public class DescribeVendorApiListResponseBodyPage : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E7698CFB-****-5840-8EC9-691B86729E94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
