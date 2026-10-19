// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// <para>The product category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Redis Community Edition.</description></item>
        /// <item><description><b>enterprise</b>: Tair (Enterprise Edition).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>redis</b>: Redis Community Edition or Tair memory-optimized.</description></item>
        /// <item><description><b>tair_pena</b>: Tair persistent memory-optimized.</description></item>
        /// <item><description><b>tair_pdb</b>: Tair disk-optimized (ESSD/SSD).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The compatible version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Redis Community Edition supports <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</description></item>
        /// <item><description>Tair memory-optimized is compatible with Redis 5.0, 6.0, and 7.0 protocols. Set this parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>Tair persistent memory-optimized is compatible with the Redis 6.0 protocol. Set this parameter to <b>1.0</b>.</description></item>
        /// <item><description>Tair disk-optimized (ESSD/SSD) is compatible with the Redis 6.0 protocol. To create a parameter template for the ESSD type, set this parameter to <b>1.0</b>. To create a parameter template for the SSD type, set this parameter to <b>2.0</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The description of the parameter template. The description can be 0 to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// <para>The name of the parameter template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, and underscores (_). It must start with a letter and cannot contain Chinese characters.</description></item>
        /// <item><description>The name must be 8 to 64 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tw_test1</para>
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// <para>A JSON string that consists of parameters and their values, in the following format: {&quot;Parameter 1&quot;:&quot;Value of Parameter 1&quot;,&quot;Parameter 2&quot;:&quot;Value of Parameter 2&quot;...}.</para>
        /// <remarks>
        /// <para>The parameters that can be added vary by version. Refer to the console for details.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;hz&quot;:&quot;15&quot;,&quot;#no_loose_disabled-commands&quot;:&quot;flushall&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
