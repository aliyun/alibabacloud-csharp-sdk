// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CloneLinkeBahamutAoneinternalconverttolinkeiterationformResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CloneLinkeBahamutAoneinternalconverttolinkeiterationformResponseBodyResult Result { get; set; }
        public class CloneLinkeBahamutAoneinternalconverttolinkeiterationformResponseBodyResult : TeaModel {
            [NameInMap("TestOwner")]
            [Validation(Required=false)]
            public string TestOwner { get; set; }
            [NameInMap("WorkItems")]
            [Validation(Required=false)]
            public List<string> WorkItems { get; set; }
            [NameInMap("AoneCodeChangeId")]
            [Validation(Required=false)]
            public string AoneCodeChangeId { get; set; }
            [NameInMap("IsBranchRelease")]
            [Validation(Required=false)]
            public bool? IsBranchRelease { get; set; }
            [NameInMap("PrePubOwner")]
            [Validation(Required=false)]
            public string PrePubOwner { get; set; }
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<string> Users { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("AppForms")]
            [Validation(Required=false)]
            public string AppForms { get; set; }
            [NameInMap("IterationManager")]
            [Validation(Required=false)]
            public string IterationManager { get; set; }
        };

    }

}
