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
            /// <para>The status of the tracking cookie. Valid values:</para>
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
            /// <para>The status of the secure attribute of the tracking cookie. Valid values:</para>
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
            /// <para>The status of the secure attribute of the slider cookie. Valid values:</para>
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
            /// <para>The list of specified header fields.</para>
            /// <remarks>
            /// <para>When XffStatus is set to 1, the first IP address in the specified header field is used as the client source IP address to prevent XFF forgery. If multiple header fields are specified, they are tried in order to obtain the source IP address. If the source IP address cannot be obtained from the first header field, the second header field is tried, and so on. If the source IP address cannot be obtained from any of the specified header fields, the first IP address in X-Forwarded-For is used. When XffStatus is set to 1, it indicates that the source IP address is obtained from the first header field.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("CustomHeaders")]
            [Validation(Required=false)]
            public List<string> CustomHeaders { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The detailed description of the protected object. Different key-value pairs in the Map represent different attributes of the protected object.</para>
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
            /// <para>The ID of the WAF instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-wwo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The UID of the owner of the protected object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170457******9107</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The protection form of the protected object.</para>
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
            /// <para>The name of the protected object group to which the protected object is added.</para>
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
            /// <item><description><para><b>custom</b>: the protected object created from Access Management.</para>
            /// </description></item>
            /// <item><description><para><b>access</b>: the protected object created by the user.</para>
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
            /// <para>The status of the protected object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>initializing</b>: default protection is being initialized.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: running normally.</para>
            /// </description></item>
            /// <item><description><para><b>init_failed</b>: default protection initialization failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("ResourceStatus")]
            [Validation(Required=false)]
            public string ResourceStatus { get; set; }

            /// <summary>
            /// <para>The response header parameters.</para>
            /// </summary>
            [NameInMap("ResponseHeaders")]
            [Validation(Required=false)]
            public List<DescribeDefenseResourceResponseBodyResourceResponseHeaders> ResponseHeaders { get; set; }
            public class DescribeDefenseResourceResponseBodyResourceResponseHeaders : TeaModel {
                /// <summary>
                /// <para>The key of the specified custom response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header-Key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the specified custom response header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header-Value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether a Layer 7 proxy (Anti-DDoS/CDN, etc.) is deployed in front of WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: not enabled.</para>
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
