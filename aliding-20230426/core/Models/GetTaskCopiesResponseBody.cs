// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetTaskCopiesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTaskCopiesResponseBodyData> Data { get; set; }
        public class GetTaskCopiesResponseBodyData : TeaModel {
            [NameInMap("ActionExecutorId")]
            [Validation(Required=false)]
            public List<string> ActionExecutorId { get; set; }

            [NameInMap("ActionExecutorName")]
            [Validation(Required=false)]
            public List<string> ActionExecutorName { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CarbonActivityId")]
            [Validation(Required=false)]
            public string CarbonActivityId { get; set; }

            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("CurrentActivityInstances")]
            [Validation(Required=false)]
            public List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetTaskCopiesResponseBodyDataCurrentActivityInstances : TeaModel {
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("ActivityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("ActivityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("DataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("OriginatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            [NameInMap("OriginatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("ProcessApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            [NameInMap("ProcessApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("ProcessInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            [NameInMap("ProcessInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

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
