// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetLogEventResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLogEventResponseBodyData Data { get; set; }
        public class GetLogEventResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetLogEventResponseBodyDataRecords> Records { get; set; }
            public class GetLogEventResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>portal-dev</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello word</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>info</para>
                /// </summary>
                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("JobExecutionId")]
                [Validation(Required=false)]
                public string JobExecutionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-31 16:43:51</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:030225016025_9357_60125@127.0.0.1">030225016025_9357_60125@127.0.0.1</a>:51363</para>
                /// </summary>
                [NameInMap("WorkerAddr")]
                [Validation(Required=false)]
                public string WorkerAddr { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BAC1ADB5-EEB5-5834-93D8-522E067AF8D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
