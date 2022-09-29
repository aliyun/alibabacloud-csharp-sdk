// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListTrainingJobsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTrainingJobsResponseBodyData Data { get; set; }
        public class ListTrainingJobsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("TrainingJobs")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyDataTrainingJobs> TrainingJobs { get; set; }
            public class ListTrainingJobsResponseBodyDataTrainingJobs : TeaModel {
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

                [NameInMap("TrainingScheduleId")]
                [Validation(Required=false)]
                public string TrainingScheduleId { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

                [NameInMap("UserConfig")]
                [Validation(Required=false)]
                public string UserConfig { get; set; }

            }

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
