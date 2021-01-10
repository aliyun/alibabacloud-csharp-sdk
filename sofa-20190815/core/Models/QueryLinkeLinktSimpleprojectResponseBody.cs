// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeLinktSimpleprojectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkeLinktSimpleprojectResponseBodyData Data { get; set; }
        public class QueryLinkeLinktSimpleprojectResponseBodyData : TeaModel {
            [NameInMap("Archive")]
            [Validation(Required=false)]
            public bool? Archive { get; set; }
            [NameInMap("AsPublic")]
            [Validation(Required=false)]
            public bool? AsPublic { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ParentSign")]
            [Validation(Required=false)]
            public string ParentSign { get; set; }
            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }
            [NameInMap("SignPath")]
            [Validation(Required=false)]
            public string SignPath { get; set; }
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}
