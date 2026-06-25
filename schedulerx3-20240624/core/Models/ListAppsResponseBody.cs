// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppsResponseBodyData Data { get; set; }
        public class ListAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyDataRecords> Records { get; set; }
            public class ListAppsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The AccessToken.</para>
                /// </summary>
                [NameInMap("AccessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AppType")]
                [Validation(Required=false)]
                public int? AppType { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Indicates whether logging is enabled.</para>
                /// <list type="bullet">
                /// <item><description><para>true: enabled.</para>
                /// </description></item>
                /// <item><description><para>false: disabled.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("EnableLog")]
                [Validation(Required=false)]
                public bool? EnableLog { get; set; }

                /// <summary>
                /// <para>The number of executors.</para>
                /// </summary>
                [NameInMap("ExecutorNum")]
                [Validation(Required=false)]
                public long? ExecutorNum { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of jobs.</para>
                /// </summary>
                [NameInMap("JobNum")]
                [Validation(Required=false)]
                public int? JobNum { get; set; }

                /// <summary>
                /// <para>The label route strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LabelRouteStrategy")]
                [Validation(Required=false)]
                public int? LabelRouteStrategy { get; set; }

                /// <summary>
                /// <para>The leader address.</para>
                /// </summary>
                [NameInMap("Leader")]
                [Validation(Required=false)]
                public string Leader { get; set; }

                /// <summary>
                /// <para>The maximum concurrency.</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public int? MaxConcurrency { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The maximum number of jobs.</para>
                /// </summary>
                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                [Obsolete]
                public int? MaxJobs { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para>The worker group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WorkerId")]
                [Validation(Required=false)]
                public int? WorkerId { get; set; }

                /// <summary>
                /// <para>The manual executor registration type.</para>
                /// </summary>
                [NameInMap("WorkerRegistry")]
                [Validation(Required=false)]
                public string WorkerRegistry { get; set; }

                /// <summary>
                /// <para>The worker type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openclaw</para>
                /// </summary>
                [NameInMap("WorkerType")]
                [Validation(Required=false)]
                public string WorkerType { get; set; }

                /// <summary>
                /// <para>The current number of workflows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("WorkflowNum")]
                [Validation(Required=false)]
                public int? WorkflowNum { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use it to troubleshoot issues.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: the call was successful.</description></item>
        /// <item><description>false: the call failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
