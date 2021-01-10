// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutVcsauthorizedprojectResponseBody : TeaModel {
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
        public List<GetLinkeBahamutVcsauthorizedprojectResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutVcsauthorizedprojectResponseBodyResult : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }

            [NameInMap("HttpUrlToRepo")]
            [Validation(Required=false)]
            public string HttpUrlToRepo { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("PublicStatus")]
            [Validation(Required=false)]
            public bool? PublicStatus { get; set; }

            [NameInMap("SshUrlToRepo")]
            [Validation(Required=false)]
            public string SshUrlToRepo { get; set; }

            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            [NameInMap("VisibilityLevel")]
            [Validation(Required=false)]
            public long? VisibilityLevel { get; set; }

            [NameInMap("WebUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

    }

}
