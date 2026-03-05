// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeMonitorItemsResponseBody : TeaModel {
        [NameInMap("MonitorItems")]
        [Validation(Required=false)]
        public DescribeMonitorItemsResponseBodyMonitorItems MonitorItems { get; set; }
        public class DescribeMonitorItemsResponseBodyMonitorItems : TeaModel {
            [NameInMap("KVStoreMonitorItem")]
            [Validation(Required=false)]
            public List<DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem> KVStoreMonitorItem { get; set; }
            public class DescribeMonitorItemsResponseBodyMonitorItemsKVStoreMonitorItem : TeaModel {
                [NameInMap("MonitorKey")]
                [Validation(Required=false)]
                public string MonitorKey { get; set; }

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
