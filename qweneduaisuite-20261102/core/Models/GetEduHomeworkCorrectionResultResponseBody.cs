// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class GetEduHomeworkCorrectionResultResponseBody : TeaModel {
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
        /// <para>The business data. This field is usually empty when the task fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;request_id&quot;: &quot;req-20261116-0001&quot;,
        ///   &quot;code&quot;: &quot;SUCCESS&quot;,
        ///   &quot;message&quot;: &quot;success&quot;,
        ///   &quot;data&quot;: {
        ///     &quot;task_id&quot;: &quot;task-20261116-abc123&quot;,
        ///     &quot;status&quot;: &quot;finished&quot;,
        ///     &quot;course&quot;: &quot;math&quot;,
        ///     &quot;dewarp_url&quot;: &quot;<a href="https://example.com/dewarp.jpg">https://example.com/dewarp.jpg</a>&quot;,
        ///     &quot;angle&quot;: 0,
        ///     &quot;render_url&quot;: &quot;<a href="https://example.com/render.jpg">https://example.com/render.jpg</a>&quot;,
        ///     &quot;question_results&quot;: [
        ///       {
        ///         &quot;question_id&quot;: &quot;q-001&quot;,
        ///         &quot;question_type&quot;: &quot;choice&quot;,
        ///         &quot;question_content&quot;: &quot;1 + 1 = ?&quot;,
        ///         &quot;question_points&quot;: [
        ///           [
        ///             {&quot;x&quot;: 100, &quot;y&quot;: 100},
        ///             {&quot;x&quot;: 200, &quot;y&quot;: 100},
        ///             {&quot;x&quot;: 200, &quot;y&quot;: 150},
        ///             {&quot;x&quot;: 100, &quot;y&quot;: 150}
        ///           ]
        ///         ],
        ///         &quot;finish&quot;: true,
        ///         &quot;answer_results&quot;: [
        ///           {
        ///             &quot;check_result&quot;: &quot;correct&quot;,
        ///             &quot;check_point&quot;: {&quot;x&quot;: 150, &quot;y&quot;: 125},
        ///             &quot;answer_points&quot;: [
        ///               {&quot;x&quot;: 120, &quot;y&quot;: 120},
        ///               {&quot;x&quot;: 180, &quot;y&quot;: 120},
        ///               {&quot;x&quot;: 180, &quot;y&quot;: 130},
        ///               {&quot;x&quot;: 120, &quot;y&quot;: 130}
        ///             ],
        ///             &quot;user_answer&quot;: &quot;2&quot;,
        ///             &quot;standard_answer&quot;: &quot;2&quot;
        ///           }
        ///         ],
        ///         &quot;solution&quot;: &quot;1 + 1 = 2&quot;
        ///       }
        ///     ],
        ///     &quot;usage&quot;: {
        ///       &quot;prompt_tokens&quot;: 1000,
        ///       &quot;completion_tokens&quot;: 200,
        ///       &quot;total_tokens&quot;: 1200
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEduHomeworkCorrectionResultResponseBodyData Data { get; set; }
        public class GetEduHomeworkCorrectionResultResponseBodyData : TeaModel {
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
            /// <para>The URL of the dewarped image. If dewarp is set to false, the URL of the original image is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/dewarp.jpg">https://example.com/dewarp.jpg</a></para>
            /// </summary>
            [NameInMap("dewarpUrl")]
            [Validation(Required=false)]
            public string DewarpUrl { get; set; }

            /// <summary>
            /// <para>The array of question recognition and grading results. For more information, see the following table.</para>
            /// </summary>
            [NameInMap("questionResults")]
            [Validation(Required=false)]
            public List<GetEduHomeworkCorrectionResultResponseBodyDataQuestionResults> QuestionResults { get; set; }
            public class GetEduHomeworkCorrectionResultResponseBodyDataQuestionResults : TeaModel {
                /// <summary>
                /// <para>The array of answering and grading results for the question. For more information, see the following table.</para>
                /// </summary>
                [NameInMap("answerResults")]
                [Validation(Required=false)]
                public List<GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResults> AnswerResults { get; set; }
                public class GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResults : TeaModel {
                    /// <summary>
                    /// <para>The coordinate group of the user\&quot;s answering area. It generally contains four vertex coordinate values, arranged in the order of top-left, top-right, bottom-right, and bottom-left, such as <c>[{&quot;x&quot;: ..., &quot;y&quot;: ...}, ...]</c>.</para>
                    /// </summary>
                    [NameInMap("answerPoints")]
                    [Validation(Required=false)]
                    public List<GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResultsAnswerPoints> AnswerPoints { get; set; }
                    public class GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResultsAnswerPoints : TeaModel {
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
                    public GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResultsCheckPoint CheckPoint { get; set; }
                    public class GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsAnswerResultsCheckPoint : TeaModel {
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
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("standardAnswer")]
                    [Validation(Required=false)]
                    public string StandardAnswer { get; set; }

                    /// <summary>
                    /// <para>The student\&quot;s answer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>980</para>
                    /// </summary>
                    [NameInMap("userAnswer")]
                    [Validation(Required=false)]
                    public string UserAnswer { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the task is finished:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The task is finished.</description></item>
                /// <item><description><b>false</b>: The task is not finished.</description></item>
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
                /// <para>The coordinate group of the question area. It generally contains four vertex coordinate values, arranged in the order of top-left, top-right, bottom-right, and bottom-left.</para>
                /// 
                /// <b>Example:</b>
                /// <para><c>[[{&quot;x&quot;: 120, &quot;y&quot;: 980}, ...]]</c></para>
                /// </summary>
                [NameInMap("questionPoints")]
                [Validation(Required=false)]
                public List<List<GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsQuestionPoints>> QuestionPoints { get; set; }
                public class GetEduHomeworkCorrectionResultResponseBodyDataQuestionResultsQuestionPoints : TeaModel {
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
                /// <para>Multiple-choice question, applied subjective question, problem-solving question, calculation question, etc</para>
                /// </summary>
                [NameInMap("questionType")]
                [Validation(Required=false)]
                public string QuestionType { get; set; }

                /// <summary>
                /// <para>The question analysis or solution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Question analysis or solution</para>
                /// </summary>
                [NameInMap("solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

            }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>submitted, processing, finished, or failed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The unique identifier of the task.</para>
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
        /// <para>The request ID, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-20261116-0001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
