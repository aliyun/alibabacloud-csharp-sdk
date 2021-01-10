// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutAoneinternaldefectsResponseBody : TeaModel {
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
        public List<GetLinkeBahamutAoneinternaldefectsResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutAoneinternaldefectsResponseBodyResult : TeaModel {
            [NameInMap("AssignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("SeriousLevel")]
            [Validation(Required=false)]
            public string SeriousLevel { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

    }

}
