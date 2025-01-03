// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestResultListResponseBody : TeaModel {
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

        [NameInMap("testResult")]
        [Validation(Required=false)]
        public List<GetTestResultListResponseBodyTestResult> TestResult { get; set; }
        public class GetTestResultListResponseBodyTestResult : TeaModel {
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public GetTestResultListResponseBodyTestResultAssignedTo AssignedTo { get; set; }
            public class GetTestResultListResponseBodyTestResultAssignedTo : TeaModel {
                [NameInMap("assignedToIdenttifier")]
                [Validation(Required=false)]
                public string AssignedToIdenttifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("bugCount")]
            [Validation(Required=false)]
            public long? BugCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Req</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetTestResultListResponseBodyTestResultCustomFields> CustomFields { get; set; }
            public class GetTestResultListResponseBodyTestResultCustomFields : TeaModel {
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

            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试工作项</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("testResultExecutor")]
            [Validation(Required=false)]
            public GetTestResultListResponseBodyTestResultTestResultExecutor TestResultExecutor { get; set; }
            public class GetTestResultListResponseBodyTestResultTestResultExecutor : TeaModel {
                [NameInMap("executorIdentifier")]
                [Validation(Required=false)]
                public string ExecutorIdentifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("testResultGmtCreate")]
            [Validation(Required=false)]
            public long? TestResultGmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a8bxxxxxxxxxxxxxxxx54</para>
            /// </summary>
            [NameInMap("testResultIdentifier")]
            [Validation(Required=false)]
            public string TestResultIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TO DO</para>
            /// </summary>
            [NameInMap("testResultStatus")]
            [Validation(Required=false)]
            public string TestResultStatus { get; set; }

            [NameInMap("testcaseIdentifier")]
            [Validation(Required=false)]
            public string TestcaseIdentifier { get; set; }

        }

    }

}
