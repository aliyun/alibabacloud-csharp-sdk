// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRuleStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The quaternary condition by which to group the rule statistics. This value cannot be the same as the primary, secondary, or tertiary condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>riskLevel</para>
        /// </summary>
        [NameInMap("FourthKey")]
        [Validation(Required=false)]
        public string FourthKey { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to obtain the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0xldbqt****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The primary condition by which to group the rule statistics.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scene</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The secondary condition by which to group the rule statistics. This value cannot be the same as the primary condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action</para>
        /// </summary>
        [NameInMap("SecondaryKey")]
        [Validation(Required=false)]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// <para>The ID of the protection template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239136</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The tertiary condition by which to group the rule statistics. This value cannot be the same as the primary or secondary condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("ThirdKey")]
        [Validation(Required=false)]
        public string ThirdKey { get; set; }

    }

}
