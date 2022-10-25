// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class ListRepositoryCodeResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListRepositoryCodeResponseBodyResult> Result { get; set; }
        public class ListRepositoryCodeResponseBodyResult : TeaModel {
            [NameInMap("DocId")]
            [Validation(Required=false)]
            public string DocId { get; set; }

            [NameInMap("HighlightTextMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> HighlightTextMap { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public ListRepositoryCodeResponseBodyResultSource Source { get; set; }
            public class ListRepositoryCodeResponseBodyResultSource : TeaModel {
                [NameInMap("Branch")]
                [Validation(Required=false)]
                public string Branch { get; set; }

                [NameInMap("CheckinDate")]
                [Validation(Required=false)]
                public string CheckinDate { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FilePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("OrganizationId")]
                [Validation(Required=false)]
                public string OrganizationId { get; set; }

                [NameInMap("RepoPath")]
                [Validation(Required=false)]
                public string RepoPath { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
