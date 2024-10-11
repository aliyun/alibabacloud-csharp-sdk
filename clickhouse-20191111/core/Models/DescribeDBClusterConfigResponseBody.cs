// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeDBClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the parameter settings of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;name&quot;: &quot;keep_alive_timeout&quot;, &quot;defaultValue&quot;: 300, &quot;currentValue&quot;: 300, &quot;restart&quot;: true, &quot;valueRange&quot;: &quot;&gt;0&quot;, &quot;desc&quot;: &quot;The number of seconds that ClickHouse waits for incoming requests before closing the connection.&quot; }, ... ,{ &quot;name&quot;: &quot;max_partition_size_to_drop&quot;, &quot;defaultValue&quot;: 0, &quot;currentValue&quot;: 0, &quot;restart&quot;: true, &quot;valueRange&quot;: &quot;&gt;=0&quot;, &quot;desc&quot;: &quot;If the size of a MergeTree partition exceeds max_partition_size_to_drop (in bytes), you can’t delete it using a DROP query.&quot; } ]</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9A23C87D-87DF-4DA0-A50E-CB13F4F7923D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
