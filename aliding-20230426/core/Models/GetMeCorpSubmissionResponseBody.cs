// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMeCorpSubmissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetMeCorpSubmissionResponseBodyData> Data { get; set; }
        public class GetMeCorpSubmissionResponseBodyData : TeaModel {
            [NameInMap("Actioner")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataActioner> Actioner { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataActioner : TeaModel {
                [NameInMap("BuName")]
                [Validation(Required=false)]
                public string BuName { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("EmployeeType")]
                [Validation(Required=false)]
                public string EmployeeType { get; set; }

                [NameInMap("EmployeeTypeInformation")]
                [Validation(Required=false)]
                public string EmployeeTypeInformation { get; set; }

                [NameInMap("HumanResourceGroupWorkNumber")]
                [Validation(Required=false)]
                public string HumanResourceGroupWorkNumber { get; set; }

                [NameInMap("IsSystemAdmin")]
                [Validation(Required=false)]
                public bool? IsSystemAdmin { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("OrderNumber")]
                [Validation(Required=false)]
                public string OrderNumber { get; set; }

                [NameInMap("PersonalPhoto")]
                [Validation(Required=false)]
                public string PersonalPhoto { get; set; }

                [NameInMap("PersonalPhotoUrl")]
                [Validation(Required=false)]
                public string PersonalPhotoUrl { get; set; }

                [NameInMap("PinyinNameAll")]
                [Validation(Required=false)]
                public string PinyinNameAll { get; set; }

                [NameInMap("PinyinNickName")]
                [Validation(Required=false)]
                public string PinyinNickName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("SuperUserId")]
                [Validation(Required=false)]
                public string SuperUserId { get; set; }

                [NameInMap("TbWang")]
                [Validation(Required=false)]
                public string TbWang { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("ActionerId")]
            [Validation(Required=false)]
            public List<string> ActionerId { get; set; }

            [NameInMap("ActionerName")]
            [Validation(Required=false)]
            public List<string> ActionerName { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("CurrentActivityInstances")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances : TeaModel {
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("ActivityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("ActivityNameEn")]
                [Validation(Required=false)]
                public string ActivityNameEn { get; set; }

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
