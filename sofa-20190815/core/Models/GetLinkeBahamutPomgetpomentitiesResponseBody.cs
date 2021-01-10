// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutPomgetpomentitiesResponseBody : TeaModel {
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
        public List<GetLinkeBahamutPomgetpomentitiesResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutPomgetpomentitiesResponseBodyResult : TeaModel {
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("Packaging")]
            [Validation(Required=false)]
            public string Packaging { get; set; }

            [NameInMap("ParentArtifactId")]
            [Validation(Required=false)]
            public string ParentArtifactId { get; set; }

            [NameInMap("ParentGroupId")]
            [Validation(Required=false)]
            public string ParentGroupId { get; set; }

            [NameInMap("PomKeyString")]
            [Validation(Required=false)]
            public string PomKeyString { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            [NameInMap("RelativePath")]
            [Validation(Required=false)]
            public string RelativePath { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
