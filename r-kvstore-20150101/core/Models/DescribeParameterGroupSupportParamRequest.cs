// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupSupportParamRequest : TeaModel {
        /// <summary>
        /// <para>The service category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: ApsaraDB for Redis Community Edition</description></item>
        /// <item><description><b>enterprise</b>: ApsaraDB for Redis Enhanced Edition (Tair)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
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
        /// <item><description>For Tair DRAM-based instances that are compatible with Redis 5.0 or Redis 6.0, set the parameter to <b>5.0</b> or <b>6.0</b>.</description></item>
        /// <item><description>For Tair persistent memory-optimized instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>.</description></item>
        /// <item><description>For Tair ESSD-based instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>. For Tair SSD-based instances that are compatible with Redis 6.0, set the parameter to <b>2.0</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
