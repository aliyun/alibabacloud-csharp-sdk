// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListInferenceJobsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInferenceJobsResponseBodyData Data { get; set; }
        public class ListInferenceJobsResponseBodyData : TeaModel {
            [NameInMap("InferenceJobs")]
            [Validation(Required=false)]
            public List<ListInferenceJobsResponseBodyDataInferenceJobs> InferenceJobs { get; set; }
            public class ListInferenceJobsResponseBodyDataInferenceJobs : TeaModel {
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("DataPath")]
                [Validation(Required=false)]
                public string DataPath { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("History")]
                [Validation(Required=false)]
                public string History { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TargetGroupId")]
                [Validation(Required=false)]
                public string TargetGroupId { get; set; }

                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                [NameInMap("TrainingJobId")]
                [Validation(Required=false)]
                public string TrainingJobId { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

                [NameInMap("UserConfig")]
                [Validation(Required=false)]
                public string UserConfig { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
