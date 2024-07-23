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
        /// <item><description><b>Collectivity</b> (default): adds new parameters or modifies parameters in the original parameter template.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the ModifyMode parameter to Collectivity, the system adds the value of the <b>Parameters</b> parameter to the original parameter template or modifies the corresponding parameters in the original parameter template. Other parameters in the original parameter template are not affected.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><b>Individual</b>: overwrites original parameters.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the ModifyMode parameter to Individual, the system uses the value of the <b>Parameters</b> parameter to overwrite the parameter settings in the original parameter template.</para>
        /// </remarks>
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
        /// <para>The new description of the parameter template. The description can be up to 200 characters in length.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the original description of the parameter template is retained.</para>
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
        /// <para>The parameter template name.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, periods (.), and underscores (_). It must start with a letter.</description></item>
        /// <item><description>It can be 8 to 64 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the original name of the parameter template is retained.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testgroup1</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values in the parameter template. Format: {&quot;Parameter 1&quot;:&quot;Value of Parameter 1&quot;,&quot;Parameter 2&quot;:&quot;Value of Parameter 2&quot;...}. For more information about the parameters that can be modified, see <a href="https://help.aliyun.com/document_detail/96063.html">Modify the parameters of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/96751.html">Modify the parameters of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>ModifyMode</b> is set to <b>Individual</b> and this parameter is specified, the new parameters overwrite the parameters in the original parameter template.</description></item>
        /// <item><description>If you set <b>ModifyMode</b> to <b>Collectivity</b> and specify this parameter, the new parameters are added to the original parameter template, or the parameters in the original parameter template are modified.</description></item>
        /// <item><description>If you do not specify this parameter, the parameters in the original parameter template remain unchanged.</description></item>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <remarks>
        /// <para> The region of a parameter template cannot be changed. You can call the CloneParameterGroup operation to replicate a parameter template to a specific region.</para>
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
