// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduHomeworkCorrectSubmitResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEduHomeworkCorrectSubmitResponseBodyData Data { get; set; }
        public class CreateEduHomeworkCorrectSubmitResponseBodyData : TeaModel {
            [NameInMap("angle")]
            [Validation(Required=false)]
            public long? Angle { get; set; }

            [NameInMap("dewarpUrl")]
            [Validation(Required=false)]
            public string DewarpUrl { get; set; }

            [NameInMap("questionResults")]
            [Validation(Required=false)]
            public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResults> QuestionResults { get; set; }
            public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResults : TeaModel {
                [NameInMap("answerResults")]
                [Validation(Required=false)]
                public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResults> AnswerResults { get; set; }
                public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResults : TeaModel {
                    [NameInMap("answerPoints")]
                    [Validation(Required=false)]
                    public List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsAnswerPoints> AnswerPoints { get; set; }
                    public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsAnswerPoints : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.03</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("checkPoint")]
                    [Validation(Required=false)]
                    public CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsCheckPoint CheckPoint { get; set; }
                    public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsAnswerResultsCheckPoint : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0</para>
                        /// </summary>
                        [NameInMap("x")]
                        [Validation(Required=false)]
                        public long? X { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.90</para>
                        /// </summary>
                        [NameInMap("y")]
                        [Validation(Required=false)]
                        public long? Y { get; set; }

                    }

                    [NameInMap("checkResult")]
                    [Validation(Required=false)]
                    public string CheckResult { get; set; }

                    [NameInMap("standardAnswer")]
                    [Validation(Required=false)]
                    public string StandardAnswer { get; set; }

                    [NameInMap("userAnswer")]
                    [Validation(Required=false)]
                    public string UserAnswer { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("finish")]
                [Validation(Required=false)]
                public bool? Finish { get; set; }

                [NameInMap("questionContent")]
                [Validation(Required=false)]
                public string QuestionContent { get; set; }

                [NameInMap("questionId")]
                [Validation(Required=false)]
                public string QuestionId { get; set; }

                [NameInMap("questionPoints")]
                [Validation(Required=false)]
                public List<List<CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsQuestionPoints>> QuestionPoints { get; set; }
                public class CreateEduHomeworkCorrectSubmitResponseBodyDataQuestionResultsQuestionPoints : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("x")]
                    [Validation(Required=false)]
                    public long? X { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("y")]
                    [Validation(Required=false)]
                    public long? Y { get; set; }

                }

                [NameInMap("questionType")]
                [Validation(Required=false)]
                public string QuestionType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>已处理：接口耗时已恢复低于阈值（09:53后分钟平均约1.8s～3.3s）</para>
                /// </summary>
                [NameInMap("solution")]
                [Validation(Required=false)]
                public string Solution { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
