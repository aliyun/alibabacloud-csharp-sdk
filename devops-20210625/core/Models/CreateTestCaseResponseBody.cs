// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateTestCaseResponseBody : TeaModel {
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
        /// <para>18E50717-93A4-53BC-A30D-963F742A1CE6</para>
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
        public CreateTestCaseResponseBodyTestcase Testcase { get; set; }
        public class CreateTestCaseResponseBodyTestcase : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseAssignedTo AssignedTo { get; set; }
            public class CreateTestCaseResponseBodyTestcaseAssignedTo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>134xxx343xxxxx</para>
                /// </summary>
                [NameInMap("assignIdentifier")]
                [Validation(Required=false)]
                public string AssignIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3c2253c22xxxxxxxx53a</para>
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
            public CreateTestCaseResponseBodyTestcaseCreator Creator { get; set; }
            public class CreateTestCaseResponseBodyTestcaseCreator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>134xxx343xxxxx</para>
                /// </summary>
                [NameInMap("createIdentifier")]
                [Validation(Required=false)]
                public string CreateIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("detailInfo")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseDetailInfo DetailInfo { get; set; }
            public class CreateTestCaseResponseBodyTestcaseDetailInfo : TeaModel {
                [NameInMap("expectedResult")]
                [Validation(Required=false)]
                public CreateTestCaseResponseBodyTestcaseDetailInfoExpectedResult ExpectedResult { get; set; }
                public class CreateTestCaseResponseBodyTestcaseDetailInfoExpectedResult : TeaModel {
                    [NameInMap("expectContent")]
                    [Validation(Required=false)]
                    public string ExpectContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RICHTEXT</para>
                    /// </summary>
                    [NameInMap("expectContentType")]
                    [Validation(Required=false)]
                    public string ExpectContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>59253164xxxxxxf2e98dbc7e27</para>
                    /// </summary>
                    [NameInMap("expectIdentifier")]
                    [Validation(Required=false)]
                    public string ExpectIdentifier { get; set; }

                }

                [NameInMap("precondition")]
                [Validation(Required=false)]
                public CreateTestCaseResponseBodyTestcaseDetailInfoPrecondition Precondition { get; set; }
                public class CreateTestCaseResponseBodyTestcaseDetailInfoPrecondition : TeaModel {
                    [NameInMap("preContent")]
                    [Validation(Required=false)]
                    public string PreContent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RICHTEXT</para>
                    /// </summary>
                    [NameInMap("preContentType")]
                    [Validation(Required=false)]
                    public string PreContentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>59253164xxxxxxf2e98dbc7e27</para>
                    /// </summary>
                    [NameInMap("preIdentifier")]
                    [Validation(Required=false)]
                    public string PreIdentifier { get; set; }

                }

                [NameInMap("stepContent")]
                [Validation(Required=false)]
                public CreateTestCaseResponseBodyTestcaseDetailInfoStepContent StepContent { get; set; }
                public class CreateTestCaseResponseBodyTestcaseDetailInfoStepContent : TeaModel {
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
                    /// <para>59253164xxxxxxf2e98dbc7e27</para>
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
            public CreateTestCaseResponseBodyTestcaseDirectory Directory { get; set; }
            public class CreateTestCaseResponseBodyTestcaseDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0bc1150dcxxxxxxxx04c</para>
                /// </summary>
                [NameInMap("childIdentifier")]
                [Validation(Required=false)]
                public string ChildIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0bc1150dcxxxxxxxx04c</para>
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
            /// <para>5a73f81c834d013361d92bdcce</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseModifier Modifier { get; set; }
            public class CreateTestCaseResponseBodyTestcaseModifier : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>134xxx343xxxxx</para>
                /// </summary>
                [NameInMap("modifyIdentifier")]
                [Validation(Required=false)]
                public string ModifyIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a18571eba8fe9267cd8375fc06</para>
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

    }

}
