// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRuleStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The quaternary query condition. The value cannot be the same as the primary, secondary, or tertiary query condition.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The primary query condition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scene</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The secondary query condition. The value cannot be the same as the primary query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action</para>
        /// </summary>
        [NameInMap("SecondaryKey")]
        [Validation(Required=false)]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// <para>The ID of the protection template to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239136</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        /// <summary>
        /// <para>The tertiary query condition. The value cannot be the same as the primary or secondary query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status</para>
        /// </summary>
        [NameInMap("ThirdKey")]
        [Validation(Required=false)]
        public string ThirdKey { get; set; }

    }

}
