// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class MeetingFlashMinutesResponseBody : TeaModel {
        [NameInMap("basicInfo")]
        [Validation(Required=false)]
        public MeetingFlashMinutesResponseBodyBasicInfo BasicInfo { get; set; }
        public class MeetingFlashMinutesResponseBodyBasicInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>500529</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1778490089000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1778490089000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>u0VGeOiPUBSVMypV3Hylp7wXXX</para>
            /// </summary>
            [NameInMap("taskCreator")]
            [Validation(Required=false)]
            public string TaskCreator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XXX</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://shanji.dingtalk.com/app/transcribes/76XXX">https://shanji.dingtalk.com/app/transcribes/76XXX</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://shanji.dingtalk.com/app/transcribes/76XXX">https://shanji.dingtalk.com/app/transcribes/76XXX</a></para>
        /// </summary>
        [NameInMap("flashMinutesUrl")]
        [Validation(Required=false)]
        public string FlashMinutesUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("fullSummary")]
        [Validation(Required=false)]
        public string FullSummary { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("todos")]
        [Validation(Required=false)]
        public MeetingFlashMinutesResponseBodyTodos Todos { get; set; }
        public class MeetingFlashMinutesResponseBodyTodos : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<string> Actions { get; set; }

            [NameInMap("dingtalkTodoList")]
            [Validation(Required=false)]
            public List<MeetingFlashMinutesResponseBodyTodosDingtalkTodoList> DingtalkTodoList { get; set; }
            public class MeetingFlashMinutesResponseBodyTodosDingtalkTodoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1778490089000</para>
                /// </summary>
                [NameInMap("createdTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>u0VGeOiPUBSVMypV3Hylp7wXXX</para>
                /// </summary>
                [NameInMap("creatorUnionId")]
                [Validation(Required=false)]
                public string CreatorUnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>deadline</para>
                /// </summary>
                [NameInMap("deadline")]
                [Validation(Required=false)]
                public string Deadline { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dingtalkTodoId</para>
                /// </summary>
                [NameInMap("dingtalkTodoId")]
                [Validation(Required=false)]
                public string DingtalkTodoId { get; set; }

                [NameInMap("executorList")]
                [Validation(Required=false)]
                public List<MeetingFlashMinutesResponseBodyTodosDingtalkTodoListExecutorList> ExecutorList { get; set; }
                public class MeetingFlashMinutesResponseBodyTodosDingtalkTodoListExecutorList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://XXX221rNAbjNAbg_440_440.png">https://XXX221rNAbjNAbg_440_440.png</a></para>
                    /// </summary>
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>XXX</para>
                    /// </summary>
                    [NameInMap("nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>u0VGeOiPUBSVMypV3Hylp7wXXX</para>
                    /// </summary>
                    [NameInMap("unionId")]
                    [Validation(Required=false)]
                    public string UnionId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isDone")]
                [Validation(Required=false)]
                public bool? IsDone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>minutesTodoId</para>
                /// </summary>
                [NameInMap("minutesTodoId")]
                [Validation(Required=false)]
                public string MinutesTodoId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XXX</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
