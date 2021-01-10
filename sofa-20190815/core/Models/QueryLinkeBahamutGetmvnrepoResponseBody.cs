// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutGetmvnrepoResponseBody : TeaModel {
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
        public List<QueryLinkeBahamutGetmvnrepoResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutGetmvnrepoResponseBodyResult : TeaModel {
            [NameInMap("CanEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            [NameInMap("FabricStage")]
            [Validation(Required=false)]
            public string FabricStage { get; set; }

            [NameInMap("RepoFullName")]
            [Validation(Required=false)]
            public string RepoFullName { get; set; }

            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            [NameInMap("RepoUrl")]
            [Validation(Required=false)]
            public string RepoUrl { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
