// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// <para>The type of the database engine. Only <b>MySQL</b> is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        /// <summary>
        /// <para>The version of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>5.6</b></para>
        /// </description></item>
        /// <item><description><para><b>5.7</b></para>
        /// </description></item>
        /// <item><description><para><b>8.0</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the parameter template. It must be 0 to 199 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// <para>The name of the parameter template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>It must start with a letter and can contain letters, digits, and underscores (<em>). It cannot contain Chinese characters or end with an underscore (</em>).</para>
        /// </description></item>
        /// <item><description><para>It must be 8 to 64 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values. The values of the parameters must be strings. For example: <c>{&quot;wait_timeout&quot;:&quot;86400&quot;,&quot;innodb_old_blocks_time&quot;:&quot;1000&quot;}</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/207428.html">DescribeParameterTemplates</a> operation to view the details of all parameters for a specific database engine version. The details include parameter names and value ranges.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;wait_timeout&quot;:&quot;86400&quot;,&quot;innodb_old_blocks_time&quot;:&quot;1000&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the region where the parameter template is located.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query region IDs.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-**********</para>
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
