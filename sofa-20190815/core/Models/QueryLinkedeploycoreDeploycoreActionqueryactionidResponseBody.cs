// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreActionqueryactionidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkedeploycoreDeploycoreActionqueryactionidResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreActionqueryactionidResponseBodyData : TeaModel {
            [NameInMap("ActionLevel")]
            [Validation(Required=false)]
            public string ActionLevel { get; set; }
            [NameInMap("ActionStatus")]
            [Validation(Required=false)]
            public string ActionStatus { get; set; }
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }
            [NameInMap("AppService")]
            [Validation(Required=false)]
            public string AppService { get; set; }
            [NameInMap("AppServiceId")]
            [Validation(Required=false)]
            public long? AppServiceId { get; set; }
            [NameInMap("ChildId")]
            [Validation(Required=false)]
            public long? ChildId { get; set; }
            [NameInMap("ConfigurationId")]
            [Validation(Required=false)]
            public long? ConfigurationId { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }
            [NameInMap("ExecutionResult")]
            [Validation(Required=false)]
            public string ExecutionResult { get; set; }
            [NameInMap("ExecutionResultId")]
            [Validation(Required=false)]
            public long? ExecutionResultId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }
            [NameInMap("Step")]
            [Validation(Required=false)]
            public long? Step { get; set; }
            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public long? Timeout { get; set; }
            [NameInMap("SubActions")]
            [Validation(Required=false)]
            public List<string> SubActions { get; set; }
        };

    }

}
