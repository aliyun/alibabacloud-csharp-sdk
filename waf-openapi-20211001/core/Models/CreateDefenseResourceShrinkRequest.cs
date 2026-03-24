// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDefenseResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of custom header fields.</para>
        /// <remarks>
        /// <para>If you set XffStatus to 1, WAF uses the first IP address from the specified header field as the client IP address to prevent XFF forgery. If you specify multiple header fields, WAF tries to obtain the client IP address from the header fields in sequence. If WAF fails to obtain the client IP address from the specified header fields, it uses the first IP address in the X-Forwarded-For header field.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("CustomHeaders")]
        [Validation(Required=false)]
        public string CustomHeadersShrink { get; set; }

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
        /// <para>The detailed parameters of the protected object. This parameter is a string that consists of a JSON struct.</para>
        /// <remarks>
        /// <para>The parameters vary based on the values of <b>Product</b> and <b>Pattern</b>. For more information, see the &quot;<b>Description of the Detail parameter</b>&quot; section.</para>
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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the WAF instance.</para>
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
        /// <para>The ID of the account to which the protected object belongs. This parameter is used in multi-account scenarios. By default, the protected object belongs to the WAF administrator account.</para>
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
        /// <item><description><para><b>domain</b>: domain name.</para>
        /// </description></item>
        /// <item><description><para><b>multi_service</b>: hybrid cloud deployment.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>domain</para>
        /// </summary>
        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>ecs</b>: Elastic Compute Service (ECS).</para>
        /// </description></item>
        /// <item><description><para><b>clb4</b>: Layer 4 Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>clb7</b>: Layer 7 CLB.</para>
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
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
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
        /// <item><description>Only protected objects of hybrid cloud deployments support custom names.</description></item>
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
        /// <para>The name of the protection group to which you want to add the protected object. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup</para>
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
        /// <para>The source of the protected object. Only the following value is supported:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: a custom object.</description></item>
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
        /// <para>A list of tags. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDefenseResourceShrinkRequestTag> Tag { get; set; }
        public class CreateDefenseResourceShrinkRequestTag : TeaModel {
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
        /// <para>Specifies whether to enable the X-Forwarded-For (XFF) proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: disabled. This is the default value.</para>
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
