// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CommitContactFlowVersionModificationResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ContactFlowVersion")]
        [Validation(Required=false)]
        public CommitContactFlowVersionModificationResponseBodyContactFlowVersion ContactFlowVersion { get; set; }
        public class CommitContactFlowVersionModificationResponseBodyContactFlowVersion : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }
            [NameInMap("Canvas")]
            [Validation(Required=false)]
            public string Canvas { get; set; }
            [NameInMap("LockedBy")]
            [Validation(Required=false)]
            public string LockedBy { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }
            [NameInMap("ContactFlowVersionId")]
            [Validation(Required=false)]
            public string ContactFlowVersionId { get; set; }
            [NameInMap("LastModifiedBy")]
            [Validation(Required=false)]
            public string LastModifiedBy { get; set; }
            [NameInMap("ContactFlowVersionDescription")]
            [Validation(Required=false)]
            public string ContactFlowVersionDescription { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
