// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeMonitorItemsResponseBody : TeaModel {
        /// <summary>
        /// The unit of the metric.
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
                /// DescribeMonitorItems
                /// </summary>
                [NameInMap("MonitorKey")]
                [Validation(Required=false)]
                public string MonitorKey { get; set; }

                /// <summary>
                /// Queries the metrics of an ApsaraDB for Redis instance.
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMonitorItems**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
