// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>618F2626-DB27-5187-8C6C-4E61A491****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of protected objects.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourcesResponseBodyResources> Resources { get; set; }
        public class DescribeDefenseResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tracking cookie feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AcwCookieStatus")]
            [Validation(Required=false)]
            public int? AcwCookieStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the secure attribute of the tracking cookie is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwSecureStatus")]
            [Validation(Required=false)]
            public int? AcwSecureStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the secure attribute of the slider CAPTCHA cookie is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwV3SecureStatus")]
            [Validation(Required=false)]
            public int? AcwV3SecureStatus { get; set; }

            /// <summary>
            /// <para>The custom XFF header that is used to obtain the real IP address of a client. If \<c>XffStatus\\</c> is set to 1 and this parameter is left empty, the first IP address in the XFF header is used as the client IP address.</para>
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            /// <summary>
            /// <para>The description of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The details of the protected object. The key-value pairs vary by product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;domain&quot;:&quot;eou.eleme.cn&quot;,&quot;uri&quot;:&quot;/&quot;}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            /// <summary>
            /// <para>The time when the protected object was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652149203187</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the protected object was modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665633032000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-k*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The account to which the asset of the protected object belongs. This parameter is returned in a multi-account management scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135*********46</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The protection mode of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The type of cloud service to which the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The name of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-rencs***</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The name of the protected object group to which the protected object is added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfm***q</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The source of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResourceOrigin")]
            [Validation(Required=false)]
            public string ResourceOrigin { get; set; }

            /// <summary>
            /// <para>The custom response headers configured for the protected object.</para>
            /// </summary>
            [NameInMap("ResponseHeaders")]
            [Validation(Required=false)]
            public List<DescribeDefenseResourcesResponseBodyResourcesResponseHeaders> ResponseHeaders { get; set; }
            public class DescribeDefenseResourcesResponseBodyResourcesResponseHeaders : TeaModel {
                /// <summary>
                /// <para>The key of the custom response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header-Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the custom response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header-Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the X-Forwarded-For (XFF) proxy is enabled for the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
