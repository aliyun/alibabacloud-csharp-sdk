// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeMonitorItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned metrics.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>memoryUsage</b>, <b>GetQps</b>, and <b>PutQps</b> are supported only by Tair instances that use Redis 4.0 or later. <b>GetQps</b> and <b>PutQps</b> require the latest minor version. You can upgrade the major version or minor version of the instance as needed. For more information, see <a href="https://help.aliyun.com/document_detail/101764.html">Upgrade the major version</a> and <a href="https://help.aliyun.com/document_detail/56450.html">Upgrade the minor version</a>.</description></item>
        /// <item><description>When you use instances of Redis 2.8, if the <b>hit_rate</b> metric is not displayed, you must upgrade the minor version of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/56450.html">Upgrade the minor version</a>.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("MonitorItems")]
        [Validation(Required=false)]
        public DescribeMonitorItemsResponseBodyMonitorItems MonitorItems { get; set; }
        public class DescribeMonitorItemsResponseBodyMonitorItems : TeaModel {
            [NameInMap("KVStoreMonitorItem")]
            [Validation(Required=false)]
            public List<DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem> KVStoreMonitorItem { get; set; }
            public class DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem : TeaModel {
                /// <summary>
                /// <para>The metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select</para>
                /// </summary>
                [NameInMap("MonitorKey")]
                [Validation(Required=false)]
                public string MonitorKey { get; set; }

                /// <summary>
                /// <para>The unit of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Counts/s</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8BEB2618-9517-43F3-A233-E0B34512****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
