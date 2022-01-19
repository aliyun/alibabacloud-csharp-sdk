// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeLorneTasksMetricsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeLorneTasksMetricsResponseBodyData Data { get; set; }
        public class DescribeLorneTasksMetricsResponseBodyData : TeaModel {
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
