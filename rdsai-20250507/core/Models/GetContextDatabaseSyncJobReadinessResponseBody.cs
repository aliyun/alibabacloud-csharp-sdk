// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncJobReadinessResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContextDatabaseSyncJobReadinessResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncJobReadinessResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reason for the automatic pause.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Three consecutive execution failures</para>
            /// </summary>
            [NameInMap("AutoPauseReason")]
            [Validation(Required=false)]
            public string AutoPauseReason { get; set; }

            /// <summary>
            /// <para>The summary of check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;jobEnabled&quot;:true,&quot;connectionReady&quot;:true,&quot;selectionConfirmed&quot;:true,&quot;scheduleConfigured&quot;:true,&quot;scheduleNotAutoPaused&quot;:true}</para>
            /// </summary>
            [NameInMap("Checks")]
            [Validation(Required=false)]
            public GetContextDatabaseSyncJobReadinessResponseBodyDataChecks Checks { get; set; }
            public class GetContextDatabaseSyncJobReadinessResponseBodyDataChecks : TeaModel {
                /// <summary>
                /// <para>Indicates whether the data source is ready.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ConnectionReady")]
                [Validation(Required=false)]
                public bool? ConnectionReady { get; set; }

                /// <summary>
                /// <para>Indicates whether the import task is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("JobEnabled")]
                [Validation(Required=false)]
                public bool? JobEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether scheduling is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScheduleConfigured")]
                [Validation(Required=false)]
                public bool? ScheduleConfigured { get; set; }

                /// <summary>
                /// <para>Indicates whether scheduling is not automatically paused.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScheduleNotAutoPaused")]
                [Validation(Required=false)]
                public bool? ScheduleNotAutoPaused { get; set; }

                /// <summary>
                /// <para>Indicates whether the selection is confirmed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SelectionConfirmed")]
                [Validation(Required=false)]
                public bool? SelectionConfirmed { get; set; }

                /// <summary>
                /// <para>Indicates whether the target is ready.</para>
                /// </summary>
                [NameInMap("TargetReady")]
                [Validation(Required=false)]
                public bool? TargetReady { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the task is ready.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Ready")]
            [Validation(Required=false)]
            public bool? Ready { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is ready for a manual run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReadyForManualRun")]
            [Validation(Required=false)]
            public bool? ReadyForManualRun { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is ready for a scheduled run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ReadyForScheduledRun")]
            [Validation(Required=false)]
            public bool? ReadyForScheduledRun { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
