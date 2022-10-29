// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemInfoResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitem")]
        [Validation(Required=false)]
        public GetWorkItemInfoResponseBodyWorkitem Workitem { get; set; }
        public class GetWorkItemInfoResponseBodyWorkitem : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetWorkItemInfoResponseBodyWorkitemCustomFields> CustomFields { get; set; }
            public class GetWorkItemInfoResponseBodyWorkitemCustomFields : TeaModel {
                [NameInMap("fieldClassName")]
                [Validation(Required=false)]
                public string FieldClassName { get; set; }

                [NameInMap("fieldFormat")]
                [Validation(Required=false)]
                public string FieldFormat { get; set; }

                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                [NameInMap("objectValue")]
                [Validation(Required=false)]
                public string ObjectValue { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueList")]
                [Validation(Required=false)]
                public List<GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList> ValueList { get; set; }
                public class GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList : TeaModel {
                    [NameInMap("displayValue")]
                    [Validation(Required=false)]
                    public string DisplayValue { get; set; }

                    [NameInMap("identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("valueEn")]
                    [Validation(Required=false)]
                    public string ValueEn { get; set; }

                }

                [NameInMap("workitemIdentifier")]
                [Validation(Required=false)]
                public string WorkitemIdentifier { get; set; }

            }

            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("logicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("parentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            [NameInMap("participant")]
            [Validation(Required=false)]
            public List<string> Participant { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("sprint")]
            [Validation(Required=false)]
            public List<string> Sprint { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusIdentifier")]
            [Validation(Required=false)]
            public string StatusIdentifier { get; set; }

            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public List<string> Tag { get; set; }

            [NameInMap("tracker")]
            [Validation(Required=false)]
            public List<string> Tracker { get; set; }

            [NameInMap("updateStatusAt")]
            [Validation(Required=false)]
            public long? UpdateStatusAt { get; set; }

            [NameInMap("verifier")]
            [Validation(Required=false)]
            public List<string> Verifier { get; set; }

            [NameInMap("workitemTypeIdentifier")]
            [Validation(Required=false)]
            public string WorkitemTypeIdentifier { get; set; }

        }

    }

}
