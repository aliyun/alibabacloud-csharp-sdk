// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListAgentMJobInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success. Other values indicate failure. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAgentMJobInfoResponseBodyData> Data { get; set; }
        public class ListAgentMJobInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The end time of the scan range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 20:00:00</para>
            /// </summary>
            [NameInMap("DataEndTime")]
            [Validation(Required=false)]
            public string DataEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the scan range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 19:00:00</para>
            /// </summary>
            [NameInMap("DataStartTime")]
            [Validation(Required=false)]
            public string DataStartTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The error message, if an error occurs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>queing: The task is queued.</description></item>
            /// <item><description>readyAnalysis: The task is pending analysis.</description></item>
            /// <item><description>running: The task is running.</description></item>
            /// <item><description>error: The task failed.</description></item>
            /// <item><description>finish: The task is complete.</description></item>
            /// <item><description>fileUploadUser: The user-specified file is uploaded.</description></item>
            /// <item><description>fileUploadSystem: The system-generated file is uploaded.</description></item>
            /// <item><description>expired: The task has expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>finish</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The actual end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 20:00:00</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public string TaskEndTime { get; set; }

            /// <summary>
            /// <para>The scheduled task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250728-8B43DF47-24DB-1CED-8D74-2AB204187D45</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The actual start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26 19:00:00</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

        }

        /// <summary>
        /// <para>The error message, if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>D10B9203-1A6A-49DA-AE56-4D160DD37DBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false/null: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
