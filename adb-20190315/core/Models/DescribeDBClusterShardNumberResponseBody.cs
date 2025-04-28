// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterShardNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>The supported numbers of shards, including the number of current shards and the number of desired shards.</para>
        /// </summary>
        [NameInMap("AvailableShardNumberList")]
        [Validation(Required=false)]
        public List<DescribeDBClusterShardNumberResponseBodyAvailableShardNumberList> AvailableShardNumberList { get; set; }
        public class DescribeDBClusterShardNumberResponseBodyAvailableShardNumberList : TeaModel {
            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("ShardNumber")]
            [Validation(Required=false)]
            public int? ShardNumber { get; set; }

        }

        /// <summary>
        /// <para>The number of desired shards, excluding the number of current shards.</para>
        /// </summary>
        [NameInMap("AvailableShardNumbers")]
        [Validation(Required=false)]
        public List<int?> AvailableShardNumbers { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBE843D8-964D-5EA3-9D31-822125611B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of shards that you want to change during the data migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ShardNumber")]
        [Validation(Required=false)]
        public int? ShardNumber { get; set; }

    }

}
