// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefenseResourceXffRequest : TeaModel {
        /// <summary>
        /// <para>The status of the tracking cookie.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1 (default)</b>: Enabled.</para>
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
        /// <para>The status of the secure attribute of the tracking cookie.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0 (default)</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled.</para>
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
        /// <para>The status of the secure attribute of the slider CAPTCHA cookie.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0 (default)</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled.</para>
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
        /// <para>The custom header fields.</para>
        /// <remarks>
        /// <para>The first IP address in the specified header field is used as the client source IP address to prevent X-Forwarded-For (XFF) spoofing. If multiple headers are specified, they are tried in sequence to obtain the source IP address. If the first header does not contain an IP address, the system tries the second header, and so on. If no IP address is found in any of the specified headers, the system uses the first IP address in the X-Forwarded-For header.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public List<string> CustomHeaders { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-wwo****ek07</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: The Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the protected object.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-4pxu81fgagx3h6y****-alb</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2ki****miwq</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The response header parameters.</para>
        /// </summary>
        [NameInMap("ResponseHeaders")]
        [Validation(Required=false)]
        public List<ModifyDefenseResourceXffRequestResponseHeaders> ResponseHeaders { get; set; }
        public class ModifyDefenseResourceXffRequestResponseHeaders : TeaModel {
            /// <summary>
            /// <para>Specifies the key for a custom response header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Header-Key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies the value for a custom response header.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Header-Value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether a Layer 7 proxy is deployed in front of WAF. Layer 7 proxies include Anti-DDoS Proxy and Alibaba Cloud CDN. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0 (default)</b>: No.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Yes.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("XffStatus")]
        [Validation(Required=false)]
        public int? XffStatus { get; set; }

    }

}
