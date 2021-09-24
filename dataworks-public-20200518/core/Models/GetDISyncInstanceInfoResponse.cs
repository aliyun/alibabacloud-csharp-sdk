// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDISyncInstanceInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDISyncInstanceInfoResponseData Data { get; set; }
        public class GetDISyncInstanceInfoResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
            [NameInMap("SolutionInfo")]
            [Validation(Required=true)]
            public GetDISyncInstanceInfoResponseDataSolutionInfo SolutionInfo { get; set; }
            public class GetDISyncInstanceInfoResponseDataSolutionInfo : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=true)]
                public long? Id { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=true)]
                public string CreatorName { get; set; }

                [NameInMap("StepDetail")]
                [Validation(Required=true)]
                public List<GetDISyncInstanceInfoResponseDataSolutionInfoStepDetail> StepDetail { get; set; }
                public class GetDISyncInstanceInfoResponseDataSolutionInfoStepDetail : TeaModel {
                    [NameInMap("StepName")]
                    [Validation(Required=true)]
                    public string StepName { get; set; }

                    [NameInMap("StepId")]
                    [Validation(Required=true)]
                    public long? StepId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=true)]
                    public string Status { get; set; }

                }

            }
        };

    }

}
