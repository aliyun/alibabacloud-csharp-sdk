// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class CreateParameterGroupRequest : TeaModel {
        /// <summary>
        /// <para>The service category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Community Edition</description></item>
        /// <item><description><b>enterprise</b>: Enhanced Edition (Tair)</description></item>
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
        /// <item><description><b>redis</b>: ApsaraDB for Redis Community Edition instance or Tair DRAM-based instance</description></item>
        /// <item><description><b>tair_pena</b>: Tair persistent memory-optimized instance</description></item>
        /// <item><description><b>tair_pdb</b>: Tair ESSD/SSD-based instance</description></item>
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
        /// <para>The compatible engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB for Redis Community Edition instances, set the parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>For Tair DRAM-based instances that are compatible with Redis 5.0, 6.0, or 7.0, set the parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>For Tair persistent memory-optimized instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>.</description></item>
        /// <item><description>For Tair ESSD-based instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>. For Tair SSD-based instances that are compatible with Redis 6.0, set the parameter to <b>2.0</b>.</description></item>
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
        /// <para>The new name of the parameter template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain letters, digits, and underscores (_). It must start with a letter and cannot contain Chinese characters.</description></item>
        /// <item><description>The name can be 8 to 64 characters in length.</description></item>
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
        /// <para>A JSON-formatted object that specifies the parameter-value pairs. Format: {&quot;Parameter 1&quot;:&quot;Value 1&quot;,&quot;Parameter 2&quot;:&quot;Value 2&quot;...}. The specified value overwrites the original content.</para>
        /// <remarks>
        /// <para> The parameters that can be added for different editions are displayed in the console.</para>
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
