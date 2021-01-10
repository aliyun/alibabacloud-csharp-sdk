// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutVcscommitcommentResponseBody : TeaModel {
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
        public List<GetLinkeBahamutVcscommitcommentResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutVcscommitcommentResponseBodyResult : TeaModel {
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            [NameInMap("Award")]
            [Validation(Required=false)]
            public bool? Award { get; set; }

            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }

            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("Diff")]
            [Validation(Required=false)]
            public string Diff { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("LineCode")]
            [Validation(Required=false)]
            public string LineCode { get; set; }

            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            [NameInMap("System")]
            [Validation(Required=false)]
            public bool? System { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

        }

    }

}
