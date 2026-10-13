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
        /// <item><description><para><b>Collectivity</b>: adds or modifies parameters. This is the default value.</para>
        /// <remarks>
        /// <para>The parameters specified in the <b>Parameters</b> parameter are added to the current parameter template, or the existing parameters in the current parameter template are modified. Other parameters in the current parameter template remain unaffected.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>Individual</b>: overwrites parameters.</para>
        /// <remarks>
        /// <para>The content in the current parameter template is replaced with the content specified in the <b>Parameters</b> parameter.</para>
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
        /// <para>The description of the parameter template. The description must be 0 to 200 characters in length.</para>
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
        /// <para>The ID of the parameter template. You can call the DescribeParameterGroups operation to query the ID of the parameter template.</para>
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
        /// <para>The JSON string of parameters and values. Format: {&quot;Parameter 1&quot;:&quot;Value 1&quot;,&quot;Parameter 2&quot;:&quot;Value 2&quot;...}. For more information about the parameters that can be modified, see <a href="https://help.aliyun.com/document_detail/96063.html">Set the parameters of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/96751.html">Set the parameters of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the <b>ModifyMode</b> parameter is set to <b>Individual</b>, the specified parameters overwrite the original parameters in the parameter template.</description></item>
        /// <item><description>If the <b>ModifyMode</b> parameter is set to <b>Collectivity</b>, the specified parameters are added to or modified in the original parameter template.</description></item>
        /// <item><description>If you do not specify this parameter, the original parameters are retained.</description></item>
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
        /// <para>The region of a parameter template cannot be modified. You can call the CloneParameterGroup operation to copy the parameter template to another region.</para>
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
        /// <para>The ID of the resource group. You can call the DescribeDBInstanceAttribute operation to query the ID of the resource group.</para>
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
