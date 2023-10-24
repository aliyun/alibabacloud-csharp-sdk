// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationConditionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageEventOperationConditionResponseBodyData Data { get; set; }
        public class DescribeImageEventOperationConditionResponseBodyData : TeaModel {
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<DescribeImageEventOperationConditionResponseBodyDataOperations> Operations { get; set; }
            public class DescribeImageEventOperationConditionResponseBodyDataOperations : TeaModel {
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeImageEventOperationConditionResponseBodyDataOperationsConditions> Conditions { get; set; }
                public class DescribeImageEventOperationConditionResponseBodyDataOperationsConditions : TeaModel {
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    [NameInMap("SupportedMisType")]
                    [Validation(Required=false)]
                    public List<string> SupportedMisType { get; set; }

                }

                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

            }

            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public List<string> Scenarios { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
