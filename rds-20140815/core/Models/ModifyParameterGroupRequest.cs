// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyParameterGroupRequest : TeaModel {
        /// <summary>
        /// <para>The modification mode of the parameter template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Collectivity</b> (default): adds or updates parameters.</para>
        /// <remarks>
        /// <para>The parameters that you specify in the <b>Parameters</b> parameter are added to or updated in the existing parameter template. Other parameters in the existing parameter template are not affected.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>Individual</b>: overwrites the parameter template.</para>
        /// <remarks>
        /// <para>The existing parameter template is replaced with the parameters that you specify in the <b>Parameters</b> parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Collectivity</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the parameter template. The description can be up to 200 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the original parameter template description is retained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// <para>The parameter template ID. You can call the DescribeParameterGroups operation to query the parameter template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-13ppdh****</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The name of the parameter template.</para>
        /// <list type="bullet">
        /// <item><description>The name must start with a letter and can contain letters, digits, periods (.), and underscores (_).</description></item>
        /// <item><description>The name must be 8 to 64 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the original parameter template name is retained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testgroup1</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values. Format: {&quot;Parameter 1&quot;:&quot;Value 1&quot;,&quot;Parameter 2&quot;:&quot;Value 2&quot;...}. For more information about the parameters that can be modified, see <a href="https://help.aliyun.com/document_detail/96063.html">Configure the parameters of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/96751.html">Configure the parameters of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>ModifyMode</b> is set to <b>Individual</b>, the parameters that you specify overwrite the existing parameter template.</description></item>
        /// <item><description>If <b>ModifyMode</b> is set to <b>Collectivity</b>, the parameters that you specify are added to or updated in the existing parameter template. Other parameters in the existing parameter template are not affected.</description></item>
        /// <item><description>If you do not specify this parameter, the original parameter information is retained.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;back_log&quot;:&quot;3000&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
        /// <remarks>
        /// <para>The region of a parameter template cannot be changed. You can call the CloneParameterGroup operation to copy a parameter template to another region.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call the DescribeDBInstanceAttribute operation to query the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
