// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateTestCaseResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                [NameInMap("assignIdentifier")]
                [Validation(Required=false)]
                public string AssignIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("tbRoleId")]
                [Validation(Required=false)]
                public string TbRoleId { get; set; }

            }

            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseCreator Creator { get; set; }
            public class CreateTestCaseResponseBodyTestcaseCreator : TeaModel {
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

                    [NameInMap("expectContentType")]
                    [Validation(Required=false)]
                    public string ExpectContentType { get; set; }

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

                    [NameInMap("preContentType")]
                    [Validation(Required=false)]
                    public string PreContentType { get; set; }

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

                    [NameInMap("stepContentType")]
                    [Validation(Required=false)]
                    public string StepContentType { get; set; }

                    [NameInMap("stepIdentifier")]
                    [Validation(Required=false)]
                    public string StepIdentifier { get; set; }

                }

                [NameInMap("stepType")]
                [Validation(Required=false)]
                public string StepType { get; set; }

            }

            [NameInMap("directory")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseDirectory Directory { get; set; }
            public class CreateTestCaseResponseBodyTestcaseDirectory : TeaModel {
                [NameInMap("childIdentifier")]
                [Validation(Required=false)]
                public string ChildIdentifier { get; set; }

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

            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public CreateTestCaseResponseBodyTestcaseModifier Modifier { get; set; }
            public class CreateTestCaseResponseBodyTestcaseModifier : TeaModel {
                [NameInMap("modifyIdentifier")]
                [Validation(Required=false)]
                public string ModifyIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

    }

}
