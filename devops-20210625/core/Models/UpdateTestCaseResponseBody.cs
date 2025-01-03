// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateTestCaseResponseBody : TeaModel {
        [NameInMap("Testcase")]
        [Validation(Required=false)]
        public UpdateTestCaseResponseBodyTestcase Testcase { get; set; }
        public class UpdateTestCaseResponseBodyTestcase : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public UpdateTestCaseResponseBodyTestcaseAssignedTo AssignedTo { get; set; }
            public class UpdateTestCaseResponseBodyTestcaseAssignedTo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1316xxxxxx8624xxx</para>
                /// </summary>
                [NameInMap("assignIdentifier")]
                [Validation(Required=false)]
                public string AssignIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxewdds12xxx</para>
                /// </summary>
                [NameInMap("tbRoleId")]
                [Validation(Required=false)]
                public string TbRoleId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestCase</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public UpdateTestCaseResponseBodyTestcaseCreator Creator { get; set; }
            public class UpdateTestCaseResponseBodyTestcaseCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1316xxxxxx8624xxx</para>
                /// </summary>
                [NameInMap("createIdentifier")]
                [Validation(Required=false)]
                public string CreateIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("detailInfo")]
            [Validation(Required=false)]
            public UpdateTestCaseResponseBodyTestcaseDetailInfo DetailInfo { get; set; }
            public class UpdateTestCaseResponseBodyTestcaseDetailInfo : TeaModel {
                [NameInMap("expectedResult")]
                [Validation(Required=false)]
                public UpdateTestCaseResponseBodyTestcaseDetailInfoExpectedResult ExpectedResult { get; set; }
                public class UpdateTestCaseResponseBodyTestcaseDetailInfoExpectedResult : TeaModel {
                    [NameInMap("expectContent")]
                    [Validation(Required=false)]
                    public string ExpectContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MARKDOWN</para>
                    /// </summary>
                    [NameInMap("expectContentType")]
                    [Validation(Required=false)]
                    public string ExpectContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>685340d13127b01185335bd360</para>
                    /// </summary>
                    [NameInMap("expectIdentifier")]
                    [Validation(Required=false)]
                    public string ExpectIdentifier { get; set; }

                }

                [NameInMap("precondition")]
                [Validation(Required=false)]
                public UpdateTestCaseResponseBodyTestcaseDetailInfoPrecondition Precondition { get; set; }
                public class UpdateTestCaseResponseBodyTestcaseDetailInfoPrecondition : TeaModel {
                    [NameInMap("preContent")]
                    [Validation(Required=false)]
                    public string PreContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MARKDOWN</para>
                    /// </summary>
                    [NameInMap("preContentType")]
                    [Validation(Required=false)]
                    public string PreContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3354596c7b3004480b635acf95</para>
                    /// </summary>
                    [NameInMap("preIdentifier")]
                    [Validation(Required=false)]
                    public string PreIdentifier { get; set; }

                }

                [NameInMap("stepContent")]
                [Validation(Required=false)]
                public UpdateTestCaseResponseBodyTestcaseDetailInfoStepContent StepContent { get; set; }
                public class UpdateTestCaseResponseBodyTestcaseDetailInfoStepContent : TeaModel {
                    [NameInMap("stepContent")]
                    [Validation(Required=false)]
                    public string StepContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RICHTEXT</para>
                    /// </summary>
                    [NameInMap("stepContentType")]
                    [Validation(Required=false)]
                    public string StepContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ad504e6cdcd2165b28eb1e1b9f</para>
                    /// </summary>
                    [NameInMap("stepIdentifier")]
                    [Validation(Required=false)]
                    public string StepIdentifier { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TEXT/TABLE</para>
                /// </summary>
                [NameInMap("stepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

            }

            [NameInMap("directory")]
            [Validation(Required=false)]
            public UpdateTestCaseResponseBodyTestcaseDirectory Directory { get; set; }
            public class UpdateTestCaseResponseBodyTestcaseDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2973f597c14c6f533fffdcd05c</para>
                /// </summary>
                [NameInMap("childIdentifier")]
                [Validation(Required=false)]
                public string ChildIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e27b8eace6501ce51cf5d56784</para>
                /// </summary>
                [NameInMap("directoryIdentifier")]
                [Validation(Required=false)]
                public string DirectoryIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pathName")]
                [Validation(Required=false)]
                public List<string> PathName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c7f7033b021ead52cc42721382</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public UpdateTestCaseResponseBodyTestcaseModifier Modifier { get; set; }
            public class UpdateTestCaseResponseBodyTestcaseModifier : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1316xxxxxx8624xxx</para>
                /// </summary>
                [NameInMap("modifyIdentifier")]
                [Validation(Required=false)]
                public string ModifyIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1e7d7a412b91a2144ec4aa8411</para>
            /// </summary>
            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestRepo</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
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
        /// <para>Id of the request</para>
        /// 
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

    }

}
