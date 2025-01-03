// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestcaseListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>12xxxxx456</para>
                /// </summary>
                [NameInMap("assignedToIdenttifier")]
                [Validation(Required=false)]
                public string AssignedToIdenttifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Req</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetTestcaseListResponseBodyTestcaseCustomFields> CustomFields { get; set; }
            public class GetTestcaseListResponseBodyTestcaseCustomFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("fieldClassName")]
                [Validation(Required=false)]
                public string FieldClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Input</para>
                /// </summary>
                [NameInMap("fieldFormat")]
                [Validation(Required=false)]
                public string FieldFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>85702b33f14bfa82cb458173ba</para>
                /// </summary>
                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>d7f112f9d023e2108fa1b0d8</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1621578648000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8bxxxxxxxxxxxxxxxx23</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("space")]
            [Validation(Required=false)]
            public GetTestcaseListResponseBodyTestcaseSpace Space { get; set; }
            public class GetTestcaseListResponseBodyTestcaseSpace : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>22c32972b853cd703dbf0efe4c</para>
                /// </summary>
                [NameInMap("spaceIdentifier")]
                [Validation(Required=false)]
                public string SpaceIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestRepo</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试工作项</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>85702b33f14bxxxxxx58173ba</para>
                /// </summary>
                [NameInMap("tagIdentifier")]
                [Validation(Required=false)]
                public string TagIdentifier { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
