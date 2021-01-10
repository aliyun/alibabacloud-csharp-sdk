// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutAoneinternalworkitemResponseBody : TeaModel {
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
        public UpdateLinkeBahamutAoneinternalworkitemResponseBodyResult Result { get; set; }
        public class UpdateLinkeBahamutAoneinternalworkitemResponseBodyResult : TeaModel {
            [NameInMap("AkProjectId")]
            [Validation(Required=false)]
            public string AkProjectId { get; set; }
            [NameInMap("AssignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }
            [NameInMap("AssignedToStaffId")]
            [Validation(Required=false)]
            public string AssignedToStaffId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }
            [NameInMap("OtherJson")]
            [Validation(Required=false)]
            public string OtherJson { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }
            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public string PriorityId { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }
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
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("UserStaffId")]
            [Validation(Required=false)]
            public string UserStaffId { get; set; }
            [NameInMap("CfsList")]
            [Validation(Required=false)]
            public List<string> CfsList { get; set; }
        };

    }

}
