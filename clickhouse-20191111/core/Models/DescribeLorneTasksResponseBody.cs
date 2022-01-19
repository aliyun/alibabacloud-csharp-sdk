// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeLorneTasksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskDetails")]
        [Validation(Required=false)]
        public List<DescribeLorneTasksResponseBodyTaskDetails> TaskDetails { get; set; }
        public class DescribeLorneTasksResponseBodyTaskDetails : TeaModel {
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            [NameInMap("ColumnMapper")]
            [Validation(Required=false)]
            public string ColumnMapper { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SinkInstance")]
            [Validation(Required=false)]
            public string SinkInstance { get; set; }

            [NameInMap("SinkRegion")]
            [Validation(Required=false)]
            public string SinkRegion { get; set; }

            [NameInMap("SinkSchema")]
            [Validation(Required=false)]
            public string SinkSchema { get; set; }

            [NameInMap("SinkTable")]
            [Validation(Required=false)]
            public string SinkTable { get; set; }

            [NameInMap("SinkType")]
            [Validation(Required=false)]
            public string SinkType { get; set; }

            [NameInMap("SinkUser")]
            [Validation(Required=false)]
            public string SinkUser { get; set; }

            [NameInMap("SinkVpcId")]
            [Validation(Required=false)]
            public string SinkVpcId { get; set; }

            [NameInMap("SourceProject")]
            [Validation(Required=false)]
            public string SourceProject { get; set; }

            [NameInMap("SourceRegion")]
            [Validation(Required=false)]
            public string SourceRegion { get; set; }

            [NameInMap("SourceTopic")]
            [Validation(Required=false)]
            public string SourceTopic { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Strict")]
            [Validation(Required=false)]
            public string Strict { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
