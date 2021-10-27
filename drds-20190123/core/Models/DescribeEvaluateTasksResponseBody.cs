// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeEvaluateTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEvaluateTasksResponseBodyData Data { get; set; }
        public class DescribeEvaluateTasksResponseBodyData : TeaModel {
            [NameInMap("EvaluateTask")]
            [Validation(Required=false)]
            public List<DescribeEvaluateTasksResponseBodyDataEvaluateTask> EvaluateTask { get; set; }
            public class DescribeEvaluateTasksResponseBodyDataEvaluateTask : TeaModel {
                public int? AllSqlCount { get; set; }
                public int? BatchEvaluateTaskId { get; set; }
                public string DbName { get; set; }
                public int? DbType { get; set; }
                public int? EvalauteHours { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? Id { get; set; }
                public string InstId { get; set; }
                public int? Progress { get; set; }
                public string Status { get; set; }
                public string TaskName { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
