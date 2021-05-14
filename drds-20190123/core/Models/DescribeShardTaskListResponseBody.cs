// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeShardTaskListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeShardTaskListResponseBodyList> List { get; set; }
        public class DescribeShardTaskListResponseBodyList : TeaModel {
            [NameInMap("SourceTableName")]
            [Validation(Required=false)]
            public string SourceTableName { get; set; }

            [NameInMap("TargetTableName")]
            [Validation(Required=false)]
            public string TargetTableName { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public long? Expired { get; set; }

            [NameInMap("Stage")]
            [Validation(Required=false)]
            public int? Stage { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Delay")]
            [Validation(Required=false)]
            public int? Delay { get; set; }

        }

    }

}
