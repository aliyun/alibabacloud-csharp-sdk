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
        /// <item><description><b>standard</b>: Open-source Redis.</description></item>
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
        /// <item><description><b>redis</b>: Open-source Redis or Tair memory-based.</description></item>
        /// <item><description><b>tair_pena</b>: Tair persistent memory-based.</description></item>
        /// <item><description><b>tair_pdb</b>: Tair disk-based (ESSD/SSD).</description></item>
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
        /// <item><description>Open-source Redis supports <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</description></item>
        /// <item><description>Tair memory-based instances are compatible with the Redis 5.0, 6.0, and 7.0 protocols. Set the value to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>Tair persistent memory-based instances are compatible with the Redis 6.0 protocol. Set the value to <b>1.0</b>.</description></item>
        /// <item><description>Tair disk-based (ESSD/SSD) instances are compatible with the Redis 6.0 protocol. To create a parameter template for ESSD-based instances, set the value to <b>1.0</b>. To create a parameter template for SSD-based instances, set the value to <b>2.0</b>.</description></item>
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
        /// <para>The description of the parameter template. The description must be 0 to 200 characters in length.</para>
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
        /// <item><description>It must contain only letters, digits, and underscores (_). It must start with a letter and cannot contain Chinese characters.</description></item>
        /// <item><description>It must be 8 to 64 characters in length.</description></item>
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
        /// <para>The parameters and their corresponding values in JSON format. Format: {&quot;Parameter1&quot;:&quot;Value1&quot;,&quot;Parameter2&quot;:&quot;Value2&quot;...}.</para>
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
