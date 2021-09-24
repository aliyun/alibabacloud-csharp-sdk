// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncInstanceInfoResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDISyncInstanceInfoResponseBodyData Data { get; set; }
        public class GetDISyncInstanceInfoResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("SolutionInfo")]
            [Validation(Required=false)]
            public GetDISyncInstanceInfoResponseBodyDataSolutionInfo SolutionInfo { get; set; }
            public class GetDISyncInstanceInfoResponseBodyDataSolutionInfo : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("StepDetail")]
                [Validation(Required=false)]
                public List<GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail> StepDetail { get; set; }
                public class GetDISyncInstanceInfoResponseBodyDataSolutionInfoStepDetail : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("StepId")]
                    [Validation(Required=false)]
                    public long? StepId { get; set; }

                    [NameInMap("StepName")]
                    [Validation(Required=false)]
                    public string StepName { get; set; }

                }

            }
        };

    }

}
