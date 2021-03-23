// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeMonitorItemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("MonitorItems")]
        [Validation(Required=false)]
        public DescribeMonitorItemsResponseBodyMonitorItems MonitorItems { get; set; }
        public class DescribeMonitorItemsResponseBodyMonitorItems : TeaModel {
            [NameInMap("KVStoreMonitorItem")]
            [Validation(Required=false)]
            public List<DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem> KVStoreMonitorItem { get; set; }
            public class DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem : TeaModel {
                public string MonitorKey { get; set; }
                public string Unit { get; set; }
            }
        };

    }

}
