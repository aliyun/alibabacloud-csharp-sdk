// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListAllNodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListAllNodeResponseBodyResult> Result { get; set; }
        public class ListAllNodeResponseBodyResult : TeaModel {
            [NameInMap("heapPercent")]
            [Validation(Required=false)]
            public string HeapPercent { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("cpuPercent")]
            [Validation(Required=false)]
            public string CpuPercent { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("diskUsedPercent")]
            [Validation(Required=false)]
            public string DiskUsedPercent { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("loadOneM")]
            [Validation(Required=false)]
            public string LoadOneM { get; set; }

            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

        }

    }

}
