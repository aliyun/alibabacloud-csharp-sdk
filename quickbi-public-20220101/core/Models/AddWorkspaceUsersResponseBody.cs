// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddWorkspaceUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddWorkspaceUsersResponseBodyResult Result { get; set; }
        public class AddWorkspaceUsersResponseBodyResult : TeaModel {
            [NameInMap("Failure")]
            [Validation(Required=false)]
            public int? Failure { get; set; }

            [NameInMap("FailureDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailureDetail { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
