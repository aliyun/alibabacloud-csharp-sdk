// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>439AADF2-368C-5E98-B14E-3086****0573</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the protected object.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeDefenseResourceResponseBodyResource Resource { get; set; }
        public class DescribeDefenseResourceResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The status of the tracking cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwCookieStatus")]
            [Validation(Required=false)]
            public int? AcwCookieStatus { get; set; }

            /// <summary>
            /// <para>The status of the secure attribute of the tracking cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwSecureStatus")]
            [Validation(Required=false)]
            public int? AcwSecureStatus { get; set; }

            /// <summary>
            /// <para>The status of the secure attribute of the slider CAPTCHA cookie.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AcwV3SecureStatus")]
            [Validation(Required=false)]
            public int? AcwV3SecureStatus { get; set; }

            /// <summary>
            /// <para>The custom header fields.</para>
            /// <remarks>
            /// <para> If the value of XffStatus is 1, the first IP address in the specified header field is used as the originating IP address of the client to prevent X-Forwarded-For (XFF) forgery. If you specify multiple header fields, WAF reads the values of the header fields in sequence until the originating IP address is obtained. If the originating IP address cannot be obtained, the first IP address in the XFF header field is used as the originating IP address of the client.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            /// <summary>
            /// <para>The description of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The details of the protected object. Different key-value pairs indicate different attributes of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            /// &quot;product&quot;: &quot;waf&quot;,
            ///  &quot;domain&quot;: &quot;demo.aliyundoc****.com&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            /// <summary>
            /// <para>The time when the protected object was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607493144000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the protected object was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1691720010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The user ID (UID) of the Alibaba Cloud account to which the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170457******9107</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The pattern used for the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>domain</para>
            /// </summary>
            [NameInMap("Pattern")]
            [Validation(Required=false)]
            public string Pattern { get; set; }

            /// <summary>
            /// <para>The name of the cloud service.</para>
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
            /// <para>The name of the protected object group to which the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_resource_group</para>
            /// </summary>
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public string ResourceGroup { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmoiy****p2oq</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The origin of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>custom</b></description></item>
            /// <item><description><b>access</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResourceOrigin")]
            [Validation(Required=false)]
            public string ResourceOrigin { get; set; }

            [NameInMap("ResponseHeaders")]
            [Validation(Required=false)]
            public List<DescribeDefenseResourceResponseBodyResourceResponseHeaders> ResponseHeaders { get; set; }
            public class DescribeDefenseResourceResponseBodyResourceResponseHeaders : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a Layer 7 proxy is deployed in front of WAF, such as Anti-DDoS Proxy and Alibaba Cloud CDN. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No Layer 7 proxy is deployed.</description></item>
            /// <item><description><b>1</b>: A Layer 7 proxy is deployed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

    }

}
