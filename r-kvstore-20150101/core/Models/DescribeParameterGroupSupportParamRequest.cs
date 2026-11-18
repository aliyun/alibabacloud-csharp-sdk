// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupSupportParamRequest : TeaModel {
        /// <summary>
        /// <para>The product category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Open-source Redis.</description></item>
        /// <item><description><b>enterprise</b>: Tair (Redis Enterprise Edition).</description></item>
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
        /// <item><description><b>redis</b>: Open-source Redis or memory-optimized Tair.</description></item>
        /// <item><description><b>tair_pena</b>: Persistent memory-optimized Tair.</description></item>
        /// <item><description><b>tair_pdb</b>: Disk-optimized Tair (ESSD/SSD).</description></item>
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
        /// <item><description>Open-source Redis supports <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</description></item>
        /// <item><description>Memory-optimized Tair is compatible with the Redis 5.0 and Redis 6.0 protocols. Set the value to <b>5.0</b> or <b>6.0</b>.</description></item>
        /// <item><description>Persistent memory-optimized Tair is compatible with the Redis 6.0 protocol. Set the value to <b>1.0</b>.</description></item>
        /// <item><description>Disk-optimized Tair (ESSD/SSD) is compatible with the Redis 6.0 protocol. Set the value to <b>1.0</b> for ESSD-based parameter templates or <b>2.0</b> for SSD-based parameter templates.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.0</para>
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
