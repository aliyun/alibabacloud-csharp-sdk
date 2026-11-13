// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefenseRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The type of the protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the dry run mode. If you do not specify this parameter, a normal request is initiated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: initiates a dry run request. The system only checks whether the request meets the execution conditions and does not perform the operations specified in the request. If the dry run fails, the corresponding error code is returned. If the dry run succeeds, the error code Defense.Control.DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: initiates a normal request. If the check succeeds, the operations specified in the request are performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Instance ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query instance ID of the current WAF instance.</para>
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
        /// <para>The protection object or protection group. This parameter is used for protection rules whose <b>DefenseType</b> is <b>resource</b>. Specify the name of the protection object or protection group based on <b>ResourceType</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resource-api-example</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

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
        /// <para>The type of the protection target. This parameter is applicable to rules whose <b>DefenseType</b> is <b>resource</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>single (default)</b>: single protection object.</description></item>
        /// <item><description><b>group</b>: protection group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule to be modified.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/461426.html">DescribeDefenseRules</a> operation to query the ID of the protection rule. You can create a protection rule by calling the <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20002615</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The status of the protection rule to be modified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled  </description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleStatus")]
        [Validation(Required=false)]
        public int? RuleStatus { get; set; }

        /// <summary>
        /// <para>The ID of the protection rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7239</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
