// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyMajorProtectionBlackIpRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Protection for major events</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expiration timestamp. Unit: seconds.</para>
        /// <remarks>
        /// <para>A value of <b>0</b> indicates that the rule permanently takes effect.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1662603328</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP blacklist to be added. You can specify custom IP addresses or CIDR blocks for the IP blacklist. Both IPv4 and IPv6 addresses are supported. Separate multiple IP addresses with commas (,).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/425591.html">Critical event protection</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.XX.XX.2,3.XX.XX.3/24</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the IP blacklist rule for critical event protection. Before you obtain the rule ID, enable the critical event protection feature. Then, call the <a href="https://help.aliyun.com/document_detail/2712643.html">DescribeDefenseTemplates</a> operation and set DefenseScene to major_protection to obtain the ID of the critical event protection template. After that, call the <a href="https://help.aliyun.com/document_detail/461426.html">DescribeDefenseRules</a> operation to obtain the ID of the IP blacklist rule under the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20012033</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The ID of the critical event protection template. Before you obtain the template ID, enable the critical event protection feature. Then, call the <a href="https://help.aliyun.com/document_detail/2712643.html">DescribeDefenseTemplates</a> operation and set DefenseScene to major_protection to obtain the ID of the critical event protection template.</para>
        /// <remarks>
        /// <para>You can create this type of template only after you purchase critical event protection through an upgrade.</para>
        /// <para>For more information about how to enable critical event protection and create a critical event protection rule template, see <a href="https://help.aliyun.com/document_detail/425591.html">Critical event protection</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5132</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
