// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupTemplateListRequest : TeaModel {
        /// <summary>
        /// <para>The service category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Redis Open-Source Edition</description></item>
        /// <item><description><b>enterprise</b>: Tair (Enterprise Edition)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The role of the instance. Valid values: logic: logical instance. db: database instance. proxy: proxy node. cs: ConfigServer node. normal: master-replica database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>redis</b>: Redis Open-Source Edition or Tair (In-Memory)</description></item>
        /// <item><description><b>tair_pena</b>: Tair (On NVM)</description></item>
        /// <item><description><b>tair_pdb</b>: Tair (On Disk)</description></item>
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
        /// <item><description>For Redis Open-Source Edition instances, set the parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>For Tair DRAM-based instances that are compatible with Redis 5.0, 6.0, or 7.0, set the parameter to <b>5.0</b>, <b>6.0</b>, or <b>7.0</b>.</description></item>
        /// <item><description>For Tair persistent memory-optimized instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>.</description></item>
        /// <item><description>For Tair ESSD-based instances that are compatible with Redis 6.0, set the parameter to <b>1.0</b>. For Tair SSD-based instances that are compatible with Redis 6.0, set the parameter to <b>2.0</b>.</description></item>
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
