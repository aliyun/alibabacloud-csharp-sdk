// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetSearchCodePreviewResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSearchCodePreviewResponseBodyResult Result { get; set; }
        public class GetSearchCodePreviewResponseBodyResult : TeaModel {
            [NameInMap("docId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("highlightTextMap")]
            [Validation(Required=false)]
            public GetSearchCodePreviewResponseBodyResultHighlightTextMap HighlightTextMap { get; set; }
            public class GetSearchCodePreviewResponseBodyResultHighlightTextMap : TeaModel {
                [NameInMap("clob")]
                [Validation(Required=false)]
                public string Clob { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

            }

            [NameInMap("source")]
            [Validation(Required=false)]
            public GetSearchCodePreviewResponseBodyResultSource Source { get; set; }
            public class GetSearchCodePreviewResponseBodyResultSource : TeaModel {
                [NameInMap("branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                [NameInMap("checkinDate")]
                [Validation(Required=false)]
                public string CheckinDate { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("filePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("organizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("repoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
