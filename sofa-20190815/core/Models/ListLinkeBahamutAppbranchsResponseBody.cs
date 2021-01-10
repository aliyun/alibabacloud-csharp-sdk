// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeBahamutAppbranchsResponseBody : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListLinkeBahamutAppbranchsResponseBodyResult> Result { get; set; }
        public class ListLinkeBahamutAppbranchsResponseBodyResult : TeaModel {
            [NameInMap("Locked")]
            [Validation(Required=false)]
            public bool? Locked { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Commit")]
            [Validation(Required=false)]
            public ListLinkeBahamutAppbranchsResponseBodyResultCommit Commit { get; set; }
            public class ListLinkeBahamutAppbranchsResponseBodyResultCommit : TeaModel {
                [NameInMap("AuthoredData")]
                [Validation(Required=false)]
                public long? AuthoredData { get; set; }
                [NameInMap("AuthorEmail")]
                [Validation(Required=false)]
                public string AuthorEmail { get; set; }
                [NameInMap("AuthorName")]
                [Validation(Required=false)]
                public string AuthorName { get; set; }
                [NameInMap("CommittedDate")]
                [Validation(Required=false)]
                public string CommittedDate { get; set; }
                [NameInMap("CommitterEmail")]
                [Validation(Required=false)]
                public string CommitterEmail { get; set; }
                [NameInMap("CommitterName")]
                [Validation(Required=false)]
                public string CommitterName { get; set; }
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }
                [NameInMap("ShortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }
                [NameInMap("ParentIds")]
                [Validation(Required=false)]
                public List<string> ParentIds { get; set; }
            };

        }

    }

}
