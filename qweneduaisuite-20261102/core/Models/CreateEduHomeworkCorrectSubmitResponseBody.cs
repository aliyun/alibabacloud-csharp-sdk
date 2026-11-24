// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduHomeworkCorrectSubmitResponseBody : TeaModel {
        /// <summary>
        /// <para>The API status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The import command.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEduHomeworkCorrectSubmitResponseBodyData Data { get; set; }
        public class CreateEduHomeworkCorrectSubmitResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rotation angle of the image in the clockwise direction, in degrees.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }

            /// <summary>
            /// <para>The URL of the corrected image. If <c>dewarp</c> is set to <c>false</c>, the original image is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/dewarp.jpg">https://example.com/dewarp.jpg</a></para>
            /// </summary>
            [NameInMap("dewarpUrl")]
            [Validation(Required=false)]
            public string DewarpUrl { get; set; }

            /// <summary>
            /// <para>The array of question recognition and grading results.</para>
            /// </summary>
            [NameInMap("questionResults")]
            [Validation(Required=false)]
            public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResults> QuestionResults { get; set; }
            public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResults : TeaModel {
                /// <summary>
                /// <para>The array of answering and grading results for the question.</para>
                /// </summary>
                [NameInMap("answerResults")]
                [Validation(Required=false)]
                public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResults> AnswerResults { get; set; }
                public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResults : TeaModel {
                    /// <summary>
                    /// <para>The coordinate group of the user\&quot;s answering area. It generally contains four vertex coordinates, arranged in the order of top-left, top-right, bottom-right, and bottom-left, such as <c>[{&quot;x&quot;: ..., &quot;y&quot;: ...}, ...]</c>.</para>
                    /// </summary>
                    [NameInMap("answerPoints")]
                    [Validation(Required=false)]
                    public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsAnswerPoints> AnswerPoints { get; set; }
                    public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsAnswerPoints : TeaModel {
                        /// <summary>
                        /// <para>The X-axis coordinate value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>120</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The Y-axis coordinate value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>980</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The coordinates of the grading mark point, such as <c>{ &quot;x&quot;: ..., &quot;y&quot;: ... }</c>.</para>
                    /// </summary>
                    [NameInMap("checkPoint")]
                    [Validation(Required=false)]
                    public CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsCheckPoint CheckPoint { get; set; }
                    public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsCheckPoint : TeaModel {
                        /// <summary>
                        /// <para>The X-axis coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>120</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <para>The Y-axis coordinate.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>980</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    /// <summary>
                    /// <para>The grading conclusion, such as <c>correct</c>, <c>wrong</c>, or <c>partial</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>correct</para>
                    /// </summary>
                    [NameInMap("checkResult")]
                    [Validation(Required=false)]
                    public string CheckResult { get; set; }

                    /// <summary>
                    /// <para>The ground truth.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("standardAnswer")]
                    [Validation(Required=false)]
                    public string StandardAnswer { get; set; }

                    /// <summary>
                    /// <para>The student\&quot;s answer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("userAnswer")]
                    [Validation(Required=false)]
                    public string UserAnswer { get; set; }

                }

                /// <summary>
                /// <para>Specifies whether the task is completed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The task is completed.</description></item>
                /// <item><description><b>false</b>: The task is not completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("finish")]
                [Validation(Required=false)]
                public bool? Finish { get; set; }

                /// <summary>
                /// <para>The text content of the question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1 + 1 = ?</para>
                /// </summary>
                [NameInMap("questionContent")]
                [Validation(Required=false)]
                public string QuestionContent { get; set; }

                /// <summary>
                /// <para>The question ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>q-001</para>
                /// </summary>
                [NameInMap("questionId")]
                [Validation(Required=false)]
                public string QuestionId { get; set; }

                /// <summary>
                /// <para>The coordinate group of the question area. It generally contains four vertex coordinates, arranged in the order of top-left, top-right, bottom-right, and bottom-left.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Example: <c>[[{&quot;x&quot;: 0, &quot;y&quot;: 0}, ...]]</c></para>
                /// </summary>
                [NameInMap("questionPoints")]
                [Validation(Required=false)]
                public List<List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsQuestionPoints>> QuestionPoints { get; set; }
                public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsQuestionPoints : TeaModel {
                    /// <summary>
                    /// <para>The X-axis coordinate value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("x")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <para>The Y-axis coordinate value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>980</para>
                    /// </summary>
                    [NameInMap("y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                /// <summary>
                /// <para>The question type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>choice</para>
                /// </summary>
                [NameInMap("questionType")]
                [Validation(Required=false)]
                public string QuestionType { get; set; }

                /// <summary>
                /// <para>The question analysis and solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Question analysis and solution</para>
                /// </summary>
                [NameInMap("solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

            }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Examples: submitted, processing, finished, and failed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The unique identifier of the task, which must be included in subsequent queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-20261116-abc123</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID of the caller.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-20261116-0001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
