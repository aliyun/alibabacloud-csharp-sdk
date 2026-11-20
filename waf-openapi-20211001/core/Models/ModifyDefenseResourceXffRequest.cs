// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefenseResourceXffRequest : TeaModel {
        /// <summary>
        /// <para>The status of the tracking cookie switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b> (default): Enabled.</para>
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
        /// <para>The status of the Secure attribute for the tracking cookie. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Disabled.</para>
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
        /// <para>The status of the Secure attribute for the slider cookie. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): Disabled.</para>
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
        /// <para>The aggregated configuration of cookie attributes.</para>
        /// </summary>
        [NameInMap("CookieConfig")]
        [Validation(Required=false)]
        public ModifyDefenseResourceXffRequestCookieConfig CookieConfig { get; set; }
        public class ModifyDefenseResourceXffRequestCookieConfig : TeaModel {
            /// <summary>
            /// <para>The SameSite policy of the slider cookie. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>None</b>: None.</para>
            /// </description></item>
            /// <item><description><para><b>Lax</b>: Lax.</para>
            /// </description></item>
            /// <item><description><para><b>Strict</b>: Strict.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>An empty string indicates that the SameSite attribute is not configured.<br>If the SameSite policy is set to None, the Secure attribute must be enabled for the cookie.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("AcwScV3SameSite")]
            [Validation(Required=false)]
            public string AcwScV3SameSite { get; set; }

            /// <summary>
            /// <para>The SameSite policy of the tracking cookie. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>None</b>: None.</para>
            /// </description></item>
            /// <item><description><para><b>Lax</b>: Lax.</para>
            /// </description></item>
            /// <item><description><para><b>Strict</b>: Strict.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>An empty string indicates that the SameSite attribute is not configured.<br>If the SameSite policy is set to None, the Secure attribute must be enabled for the cookie.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Lax</para>
            /// </summary>
            [NameInMap("AcwTcSameSite")]
            [Validation(Required=false)]
            public string AcwTcSameSite { get; set; }

        }

        /// <summary>
        /// <para>The list of specified header fields.</para>
        /// <remarks>
        /// <para>The first IP address in the specified header field is used as the source IP address of the client to prevent X-Forwarded-For (XFF) spoofing. If multiple headers are specified, the system attempts to obtain the source IP address in sequence. If the first header does not contain an IP address, the system checks the second header, and so on. If no IP address is found in any of the specified headers, the first IP address in the X-Forwarded-For header is used.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public List<string> CustomHeaders { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the WAF instance.</para>
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
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <remarks>
        /// <para>The protected object must be added to WAF. You can call the <a href="https://help.aliyun.com/document_detail/461612.html">DescribeDefenseResources</a> operation to query the name of the protected object.</para>
        /// </remarks>
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
        /// <para>Specifies whether a Layer 7 proxy, such as Anti-DDoS or CDN, is enabled before WAF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b> (default): The proxy is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The proxy is enabled.</para>
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
