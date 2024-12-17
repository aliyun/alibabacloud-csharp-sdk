// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListJobsResponseBody : TeaModel {
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
        public ListJobsResponseBodyData Data { get; set; }
        public class ListJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
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
            public List<ListJobsResponseBodyDataRecords> Records { get; set; }
            public class ListJobsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test-app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AttemptInterval")]
                [Validation(Required=false)]
                public int? AttemptInterval { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>work-day</para>
                /// </summary>
                [NameInMap("Calendar")]
                [Validation(Required=false)]
                public string Calendar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;cleanMode&quot;:&quot;NUM_ONLY&quot;,&quot;totalRemain&quot;:300}</para>
                /// </summary>
                [NameInMap("CleanMode")]
                [Validation(Required=false)]
                public string CleanMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentExecuteStatus")]
                [Validation(Required=false)]
                public int? CurrentExecuteStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("DataOffset")]
                [Validation(Required=false)]
                public int? DataOffset { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ExecutorBlockStrategy")]
                [Validation(Required=false)]
                public string ExecutorBlockStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>jobDemoHandler</para>
                /// </summary>
                [NameInMap("JobHandler")]
                [Validation(Required=false)]
                public string JobHandler { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>74</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public long? JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxljob</para>
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public string JobType { get; set; }

                [NameInMap("LastExecuteEndTime")]
                [Validation(Required=false)]
                public string LastExecuteEndTime { get; set; }

                [NameInMap("LastExecuteStatus")]
                [Validation(Required=false)]
                public int? LastExecuteStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxAttempt")]
                [Validation(Required=false)]
                public int? MaxAttempt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public int? MaxConcurrency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{&quot;failLimitTimes&quot;:1,&quot;failEnable&quot;:true,&quot;timeoutKillEnable&quot;:false,&quot;missWorkerEnable&quot;:true,&quot;timeoutEnable&quot;:true,&quot;sendChannel&quot;:&quot;&quot;,&quot;timeout&quot;:300,&quot;successNotice&quot;:false}</para>
                /// </summary>
                [NameInMap("NoticeConfig")]
                [Validation(Required=false)]
                public string NoticeConfig { get; set; }

                [NameInMap("NoticeContacts")]
                [Validation(Required=false)]
                public string NoticeContacts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name=10</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RouteStrategy")]
                [Validation(Required=false)]
                public int? RouteStrategy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0 0 12 * * ?</para>
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HangKong</para>
                /// </summary>
                [NameInMap("TimeZone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HangKong</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                [NameInMap("Xattrs")]
                [Validation(Required=false)]
                public string Xattrs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
