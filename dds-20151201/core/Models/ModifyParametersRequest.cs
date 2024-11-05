// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyParametersRequest : TeaModel {
        /// <summary>
        /// <para>The role of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>db</b>: a shard node.</description></item>
        /// <item><description><b>cs</b>: a Configserver node.</description></item>
        /// <item><description><b>mongos</b>: a mongos node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> If you set this parameter to the ID of a sharded cluster instance, you must also specify the NodeId parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp19f409d75****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the mongos or shard node in the specified sharded cluster instance.</para>
        /// <remarks>
        /// <para> This parameter is valid only when DBInstanceId is set to the ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1b7bb3bbe****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The instance parameters that you want to modify and their values. Specify this parameter in a JSON string. Sample format: {&quot;ParameterName1&quot;:&quot;ParameterValue1&quot;,&quot;ParameterName2&quot;:&quot;ParameterValue2&quot;}.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/67618.html">DescribeParameterTemplates</a> operation to query a list of default parameter templates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;operationProfiling.mode&quot;:&quot;all&quot;,&quot;operationProfiling.slowOpThresholdMs&quot;:&quot;200&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/61933.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
