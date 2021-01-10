// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idrsservice20200630.Models
{
    public class GetDetectEvaluationResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDetectEvaluationResponseBodyData> Data { get; set; }
        public class GetDetectEvaluationResponseBodyData : TeaModel {
            [NameInMap("Day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("EvaluationItemList")]
            [Validation(Required=false)]
            public List<GetDetectEvaluationResponseBodyDataEvaluationItemList> EvaluationItemList { get; set; }
            public class GetDetectEvaluationResponseBodyDataEvaluationItemList : TeaModel {
                [NameInMap("SuccessRate")]
                [Validation(Required=false)]
                public string SuccessRate { get; set; }

                [NameInMap("HandleCount")]
                [Validation(Required=false)]
                public int? HandleCount { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public int? SuccessCount { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
