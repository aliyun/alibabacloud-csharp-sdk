// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>439AADF2-368C-5E98-B14E-3086****0573</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the protected object.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeDefenseResourceResponseBodyResource Resource { get; set; }
        public class DescribeDefenseResourceResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>Indicates whether the tracking cookie feature is enabled. Valid values:</para>
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
            [NameInMap("AcwCookieStatus")]
            [Validation(Required=false)]
            public int? AcwCookieStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the secure attribute of the tracking cookie is enabled. Valid values:</para>
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
            /// <para>Indicates whether the secure attribute of the slider CAPTCHA cookie is enabled. Valid values:</para>
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
            /// <para>The list of custom header fields used to identify the actual client IP address.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when XffStatus is set to 1. WAF uses the first IP address in the specified header fields as the client source IP address to prevent X-Forwarded-For (XFF) spoofing. If multiple headers are specified, WAF checks them in order. If the first header does not contain a source IP address, WAF checks the next header. If none of the specified headers contain a source IP address, WAF uses the first IP address in the X-Forwarded-For header.</para>
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
            /// <para>The details of the protected object. The fields vary based on the cloud service type.</para>
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
            /// <para>The time when the protected object was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1607493144000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the protected object was modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1691720010000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-wwo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the protected object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170457******9107</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The protection pattern of the protected object.</para>
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
            /// <item><description><para><b>custom</b>: The protected object is created through provisioning.</para>
            /// </description></item>
            /// <item><description><para><b>access</b>: The protected object is user-defined.</para>
            /// </description></item>
            /// </list>
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
            public List<DescribeDefenseResourceResponseBodyResourceResponseHeaders> ResponseHeaders { get; set; }
            public class DescribeDefenseResourceResponseBodyResourceResponseHeaders : TeaModel {
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
            /// <para>Indicates whether a Layer 7 proxy such as Anti-DDoS or CDN is enabled in front of WAF. Valid values:</para>
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
            [NameInMap("XffStatus")]
            [Validation(Required=false)]
            public int? XffStatus { get; set; }

        }

    }

}
