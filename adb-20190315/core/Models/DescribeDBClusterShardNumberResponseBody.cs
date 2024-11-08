// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterShardNumberResponseBody : TeaModel {
        [NameInMap("AvailableShardNumbers")]
        [Validation(Required=false)]
        public List<int?> AvailableShardNumbers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CBE843D8-964D-5EA3-9D31-822125611B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("ShardNumber")]
        [Validation(Required=false)]
        public int? ShardNumber { get; set; }

    }

}
