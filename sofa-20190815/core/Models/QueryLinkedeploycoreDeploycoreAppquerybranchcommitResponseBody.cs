// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppquerybranchcommitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkedeploycoreDeploycoreAppquerybranchcommitResponseBodyData Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreAppquerybranchcommitResponseBodyData : TeaModel {
            [NameInMap("AuthorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }
            [NameInMap("CommittedDate")]
            [Validation(Required=false)]
            public long? CommittedDate { get; set; }
            [NameInMap("CommitterName")]
            [Validation(Required=false)]
            public string CommitterName { get; set; }
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public long? CreatedDate { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

    }

}
