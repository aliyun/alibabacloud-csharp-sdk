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
        /// <item><description><b>standard</b>: ApsaraDB for Redis Community Edition.</description></item>
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
        /// <item><description><b>redis</b>: ApsaraDB for Redis Community Edition or Tair memory-optimized instances.</description></item>
        /// <item><description><b>tair_pena</b>: Tair persistent memory-optimized instances.</description></item>
        /// <item><description><b>tair_pdb</b>: Tair cloud-native (ESSD/SSD) instances.</description></item>
        /// </list>
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
        /// <item><description>ApsaraDB for Redis Community Edition supports <b>5.0</b>, <b>6.0</b>, and <b>7.0</b>.</description></item>
        /// <item><description>Tair memory-optimized instances are compatible with Redis 5.0 and Redis 6.0 protocols. Set this parameter to <b>5.0</b> or <b>6.0</b>.</description></item>
        /// <item><description>Tair persistent memory-optimized instances are compatible with the Redis 6.0 protocol. Set this parameter to <b>1.0</b>.</description></item>
        /// <item><description>Tair cloud-native (ESSD/SSD) instances are compatible with the Redis 6.0 protocol. To create a parameter template for ESSD-based instances, set this parameter to <b>1.0</b>. To create a parameter template for SSD-based instances, set this parameter to <b>2.0</b>.</description></item>
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
