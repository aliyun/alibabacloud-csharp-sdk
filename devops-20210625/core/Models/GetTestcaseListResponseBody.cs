// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestcaseListResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("testcase")]
        [Validation(Required=false)]
        public List<GetTestcaseListResponseBodyTestcase> Testcase { get; set; }
        public class GetTestcaseListResponseBodyTestcase : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public GetTestcaseListResponseBodyTestcaseAssignedTo AssignedTo { get; set; }
            public class GetTestcaseListResponseBodyTestcaseAssignedTo : TeaModel {
                [NameInMap("assignedToIdenttifier")]
                [Validation(Required=false)]
                public string AssignedToIdenttifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetTestcaseListResponseBodyTestcaseCustomFields> CustomFields { get; set; }
            public class GetTestcaseListResponseBodyTestcaseCustomFields : TeaModel {
                [NameInMap("fieldClassName")]
                [Validation(Required=false)]
                public string FieldClassName { get; set; }

                [NameInMap("fieldFormat")]
                [Validation(Required=false)]
                public string FieldFormat { get; set; }

                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("space")]
            [Validation(Required=false)]
            public GetTestcaseListResponseBodyTestcaseSpace Space { get; set; }
            public class GetTestcaseListResponseBodyTestcaseSpace : TeaModel {
                [NameInMap("spaceIdentifier")]
                [Validation(Required=false)]
                public string SpaceIdentifier { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<GetTestcaseListResponseBodyTestcaseTags> Tags { get; set; }
            public class GetTestcaseListResponseBodyTestcaseTags : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("tagIdentifier")]
                [Validation(Required=false)]
                public string TagIdentifier { get; set; }

            }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
