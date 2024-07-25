// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetBatchMediaProducingJobResponseBody : TeaModel {
        [NameInMap("EditingBatchJob")]
        [Validation(Required=false)]
        public GetBatchMediaProducingJobResponseBodyEditingBatchJob EditingBatchJob { get; set; }
        public class GetBatchMediaProducingJobResponseBodyEditingBatchJob : TeaModel {
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EditingConfig")]
            [Validation(Required=false)]
            public string EditingConfig { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("InputConfig")]
            [Validation(Required=false)]
            public string InputConfig { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("OutputConfig")]
            [Validation(Required=false)]
            public string OutputConfig { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubJobList")]
            [Validation(Required=false)]
            public List<GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList> SubJobList { get; set; }
            public class GetBatchMediaProducingJobResponseBodyEditingBatchJobSubJobList : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("MediaURL")]
                [Validation(Required=false)]
                public string MediaURL { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
