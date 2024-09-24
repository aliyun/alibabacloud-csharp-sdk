// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If the instance runs MySQL, the instance must run one of the following MySQL versions:</para>
        /// <list type="bullet">
        /// <item><description><b>5.6</b></description></item>
        /// <item><description><b>5.7</b></description></item>
        /// <item><description><b>8.0</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If the instance runs PostgreSQL, the instance must run one of the following PostgreSQL versions:</para>
        /// <list type="bullet">
        /// <item><description><b>10.0</b></description></item>
        /// <item><description><b>11.0</b></description></item>
        /// <item><description><b>12.0</b></description></item>
        /// <item><description><b>13.0</b></description></item>
        /// <item><description><b>14.0</b></description></item>
        /// <item><description><b>15.0</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the parameter template. The value can be up to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// <para>The name of the parameter template.</para>
        /// <list type="bullet">
        /// <item><description>The value must start with a letter and can contain letters, digits, periods (.), and underscores (_).</description></item>
        /// <item><description>The value can be 8 to 64 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1234</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values in the parameter template. Format: {&quot;Parameter 1&quot;:&quot;Value of Parameter 1&quot;,&quot;Parameter 2&quot;:&quot;Value of Parameter 2&quot;...}. For more information about the parameters that can be modified, see <a href="https://help.aliyun.com/document_detail/96063.html">Modify the parameters of an ApsaraDB RDS for MySQL instance</a> or <a href="https://help.aliyun.com/document_detail/96751.html">Modify the parameters of an ApsaraDB RDS for PostgreSQL instance</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;back_log&quot;:&quot;3000&quot;,&quot;wait_timeout&quot;:&quot;86400&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID of the parameter template. You can call the DescribeRegions operation to query the most recent zone list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can call the DescribeDBInstanceAttribute operation to obtain the resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
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
