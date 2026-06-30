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
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("taskCreator")]
            [Validation(Required=false)]
            public string TaskCreator { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("flashMinutesUrl")]
        [Validation(Required=false)]
        public string FlashMinutesUrl { get; set; }

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
                [NameInMap("createdTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("creatorUnionId")]
                [Validation(Required=false)]
                public string CreatorUnionId { get; set; }

                [NameInMap("deadline")]
                [Validation(Required=false)]
                public string Deadline { get; set; }

                [NameInMap("dingtalkTodoId")]
                [Validation(Required=false)]
                public string DingtalkTodoId { get; set; }

                [NameInMap("executorList")]
                [Validation(Required=false)]
                public List<MeetingFlashMinutesResponseBodyTodosDingtalkTodoListExecutorList> ExecutorList { get; set; }
                public class MeetingFlashMinutesResponseBodyTodosDingtalkTodoListExecutorList : TeaModel {
                    [NameInMap("avatar")]
                    [Validation(Required=false)]
                    public string Avatar { get; set; }

                    [NameInMap("nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    [NameInMap("unionId")]
                    [Validation(Required=false)]
                    public string UnionId { get; set; }

                }

                [NameInMap("isDone")]
                [Validation(Required=false)]
                public bool? IsDone { get; set; }

                [NameInMap("minutesTodoId")]
                [Validation(Required=false)]
                public string MinutesTodoId { get; set; }

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
