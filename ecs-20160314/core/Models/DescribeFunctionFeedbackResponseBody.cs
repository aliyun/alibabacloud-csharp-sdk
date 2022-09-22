// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeFunctionFeedbackResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeFunctionFeedbackResponseBodyData Data { get; set; }
        public class DescribeFunctionFeedbackResponseBodyData : TeaModel {
            [NameInMap("feedback")]
            [Validation(Required=false)]
            public List<DescribeFunctionFeedbackResponseBodyDataFeedback> Feedback { get; set; }
            public class DescribeFunctionFeedbackResponseBodyDataFeedback : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                [NameInMap("FinishedTime")]
                [Validation(Required=false)]
                public string FinishedTime { get; set; }

                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
