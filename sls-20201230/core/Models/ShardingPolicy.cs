// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ShardingPolicy : TeaModel {
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1764659409</para>
        /// </summary>
        [NameInMap("queryActiveTime")]
        [Validation(Required=false)]
        public long? QueryActiveTime { get; set; }

        [NameInMap("shardGroup")]
        [Validation(Required=false)]
        public ShardingPolicyShardGroup ShardGroup { get; set; }
        public class ShardingPolicyShardGroup : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("groupCount")]
            [Validation(Required=false)]
            public int? GroupCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

        }

        [NameInMap("shardHash")]
        [Validation(Required=false)]
        public ShardingPolicyShardHash ShardHash { get; set; }
        public class ShardingPolicyShardHash : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("maxHashCount")]
            [Validation(Required=false)]
            public int? MaxHashCount { get; set; }

        }

    }

}
