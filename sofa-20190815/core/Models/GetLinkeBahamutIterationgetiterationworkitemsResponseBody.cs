// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutIterationgetiterationworkitemsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutIterationgetiterationworkitemsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutIterationgetiterationworkitemsResponseBodyResult : TeaModel {
            [NameInMap("AcHour")]
            [Validation(Required=false)]
            public string AcHour { get; set; }

            [NameInMap("AssignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("AssignedToStaffId")]
            [Validation(Required=false)]
            public string AssignedToStaffId { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("CreatorStaffId")]
            [Validation(Required=false)]
            public string CreatorStaffId { get; set; }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("EsHour")]
            [Validation(Required=false)]
            public string EsHour { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IterationExternalId")]
            [Validation(Required=false)]
            public string IterationExternalId { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("MergeRequestId")]
            [Validation(Required=false)]
            public string MergeRequestId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("Stamp")]
            [Validation(Required=false)]
            public string Stamp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusId")]
            [Validation(Required=false)]
            public string StatusId { get; set; }

            [NameInMap("StatusStage")]
            [Validation(Required=false)]
            public string StatusStage { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("Sys")]
            [Validation(Required=false)]
            public string Sys { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("MergeRequestIds")]
            [Validation(Required=false)]
            public List<string> MergeRequestIds { get; set; }

        }

    }

}
