// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListInferenceJobsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInferenceJobsResponseBodyData Data { get; set; }
        public class ListInferenceJobsResponseBodyData : TeaModel {
            [NameInMap("InferenceJobs")]
            [Validation(Required=false)]
            public List<ListInferenceJobsResponseBodyDataInferenceJobs> InferenceJobs { get; set; }
            public class ListInferenceJobsResponseBodyDataInferenceJobs : TeaModel {
                public string Algorithm { get; set; }
                public string CampaignId { get; set; }
                public string CreatedTime { get; set; }
                public string DataPath { get; set; }
                public string GroupId { get; set; }
                public string History { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public string Remark { get; set; }
                public int? Status { get; set; }
                public string TargetPath { get; set; }
                public string TrainingJobId { get; set; }
                public string UpdatedTime { get; set; }
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
        };

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
