// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseResourceRequest : TeaModel {
        /// <summary>
        /// <para>The list of specified header fields.</para>
        /// <remarks>
        /// <para>When XffStatus is set to 1, the first IP in the specified header field is used as the client source IP to prevent XFF spoofing. When multiple headers are specified, the system attempts to obtain the source IP from each header in order. If the first header does not contain an IP, the system tries the second header, and so on. If no specified header contains an IP, the first IP in the X-Forwarded-For header is used. When XffStatus is set to 1, the IP is obtained from the first available header.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public List<string> CustomHeaders { get; set; }

        /// <summary>
        /// <para>The description of the protected object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The specific parameter information of the protected object, which is a string converted from a JSON object constructed with a series of parameters.</para>
        /// <remarks>
        /// <para>The parameters vary depending on the specified <b>cloud product</b> (<b>Product</b>) and <b>protection mode</b> (<b>Pattern</b>). For more information, see <b>Detail parameter description for protected objects</b>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Notice: When <b>Product</b> is set to <b>ecs</b>, <b>clb4</b>, <b>clb7</b>, or <b>nlb</b>, domain names connected to regions in the Chinese mainland must have completed ICP filing.</notice></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;domain\&quot;: \&quot;zhhclb4test096-05111.test.com\&quot;}</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-4xl*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the account to which the protected object belongs in multi-account scenarios. By default, the protected object belongs to the WAF administrator account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123221XXX</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The protection mode of the protected object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>domain</b>: domain name-based protection.</para>
        /// </description></item>
        /// <item><description><para><b>multi_service</b>: hybrid cloud service-based protection.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, only the following combinations are supported: when <b>Product</b> is set to <b>alb</b>, <b>ecs</b>, <b>clb4</b>, <b>clb7</b>, or <b>nlb</b>, <b>Pattern</b> must be set to <b>domain</b>. When <b>Product</b> is set to <b>waf</b>, <b>Pattern</b> must be set to <b>multi_service</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The cloud product name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: Classic Load Balancer (CLB) Layer 4 access.</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: Classic Load Balancer (CLB) Layer 7 access.</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// <item><description><para><b>waf</b>: Web Application Firewall (WAF).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

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
        /// <list type="bullet">
        /// <item><description>Only protected objects in hybrid cloud service mode support custom protected object names.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abctest.com</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// <para>The name of the protection group to which the protected object is added. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup</para>
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public string ResourceGroup { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The source of the protected object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: user-defined.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ResourceOrigin")]
        [Validation(Required=false)]
        public string ResourceOrigin { get; set; }

        /// <summary>
        /// <para>The tag list, which contains up to 20 items.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDefenseResourceRequestTag> Tag { get; set; }
        public class CreateDefenseResourceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demoTagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether XFF proxy is enabled for the protected object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled.</para>
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
