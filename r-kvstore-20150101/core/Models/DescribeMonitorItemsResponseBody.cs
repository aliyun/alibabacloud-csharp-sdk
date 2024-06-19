// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeMonitorItemsResponseBody : TeaModel {
        /// <summary>
        /// The returned metrics.
        /// 
        /// > *   **memoryUsage**, **GetQps**, and **PutQps** are supported only by ApsaraDB for Redis instances that use Redis 4.0 or later. **GetQps** and **PutQps** require the latest minor version. You can upgrade the major version or minor version of the instance as needed. For more information, see [Upgrade the major version](https://help.aliyun.com/document_detail/101764.html) and [Upgrade the minor version](https://help.aliyun.com/document_detail/56450.html).
        /// > *   When you use instances of Redis 2.8, if the **hit_rate** metric is not displayed, you must upgrade the minor version of the instance. For more information, see [Upgrade the minor version](https://help.aliyun.com/document_detail/56450.html).
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
                /// The metric.
                /// </summary>
                [NameInMap("MonitorKey")]
                [Validation(Required=false)]
                public string MonitorKey { get; set; }

                /// <summary>
                /// The unit of the metric.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
