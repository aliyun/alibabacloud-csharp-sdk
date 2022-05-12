// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemInfoResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求id，每次请求都是唯一值，便于后续排查问题
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// true或者false
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 工作项信息
        /// </summary>
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
                public string FieldClassName { get; set; }
                public string FieldFormat { get; set; }
                public string FieldIdentifier { get; set; }
                public long? Level { get; set; }
                public string ObjectValue { get; set; }
                public long? Position { get; set; }
                public string Value { get; set; }
                public List<GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList> ValueList { get; set; }
                public class GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList : TeaModel {
                    public string DisplayValue { get; set; }
                    public string Identifier { get; set; }
                    public long? Level { get; set; }
                    public string Value { get; set; }
                    public string ValueEn { get; set; }
                }
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
        };

    }

}
