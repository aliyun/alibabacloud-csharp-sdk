// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetCorpTasksResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCorpTasksResponseBodyData> Data { get; set; }
        public class GetCorpTasksResponseBodyData : TeaModel {
            [NameInMap("ActiveTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("ActualActionerId")]
            [Validation(Required=false)]
            public string ActualActionerId { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("OriginatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("OriginatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            [NameInMap("OriginatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            [NameInMap("OriginatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            [NameInMap("OriginatorNickNameEn")]
            [Validation(Required=false)]
            public string OriginatorNickNameEn { get; set; }

            [NameInMap("OriginatorNickNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNickNameInEnglish { get; set; }

            [NameInMap("OriginatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            [NameInMap("OutResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            [NameInMap("OutResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("TitleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
