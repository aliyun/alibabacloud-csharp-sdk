// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateTestCaseRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignedTo")]
        [Validation(Required=false)]
        public string AssignedTo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("directoryIdentifier")]
        [Validation(Required=false)]
        public string DirectoryIdentifier { get; set; }

        [NameInMap("fieldValueList")]
        [Validation(Required=false)]
        public List<CreateTestCaseRequestFieldValueList> FieldValueList { get; set; }
        public class CreateTestCaseRequestFieldValueList : TeaModel {
            [NameInMap("fieldIdentifier")]
            [Validation(Required=false)]
            public string FieldIdentifier { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        [NameInMap("testcaseStepContentInfo")]
        [Validation(Required=false)]
        public CreateTestCaseRequestTestcaseStepContentInfo TestcaseStepContentInfo { get; set; }
        public class CreateTestCaseRequestTestcaseStepContentInfo : TeaModel {
            [NameInMap("precondition")]
            [Validation(Required=false)]
            public string Precondition { get; set; }

            [NameInMap("stepResultList")]
            [Validation(Required=false)]
            public List<CreateTestCaseRequestTestcaseStepContentInfoStepResultList> StepResultList { get; set; }
            public class CreateTestCaseRequestTestcaseStepContentInfoStepResultList : TeaModel {
                [NameInMap("expected")]
                [Validation(Required=false)]
                public string Expected { get; set; }

                [NameInMap("step")]
                [Validation(Required=false)]
                public string Step { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("stepType")]
            [Validation(Required=false)]
            public string StepType { get; set; }

        }

    }

}
