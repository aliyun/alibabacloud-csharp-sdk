// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListWorkflowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkflowsResponseBodyData Data { get; set; }
        public class ListWorkflowsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries to return for this request. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token that is returned when the data that meets the query conditions is not completely read. You can use this token to continue reading the subsequent data. You do not need to specify this parameter for the first query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The list of workflows.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListWorkflowsResponseBodyDataRecords> Records { get; set; }
            public class ListWorkflowsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-app</para>
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
                /// <para>The calendar.</para>
                /// 
                /// <b>Example:</b>
                /// <para>work-day</para>
                /// </summary>
                [NameInMap("Calendar")]
                [Validation(Required=false)]
                public string Calendar { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The current execution status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Not started.</description></item>
                /// <item><description>1: Running.</description></item>
                /// <item><description>2: Queued.</description></item>
                /// <item><description>3: Waiting.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentExecuteStatus")]
                [Validation(Required=false)]
                public int? CurrentExecuteStatus { get; set; }

                /// <summary>
                /// <para>The workflow description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my first workflow</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The end time of the last execution. The format is YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-29 15:56:36</para>
                /// </summary>
                [NameInMap("LastExecuteEndTime")]
                [Validation(Required=false)]
                public string LastExecuteEndTime { get; set; }

                /// <summary>
                /// <para>The result of the last execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>4: Success.</description></item>
                /// <item><description>5: Failure.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("LastExecuteStatus")]
                [Validation(Required=false)]
                public int? LastExecuteStatus { get; set; }

                /// <summary>
                /// <para>The maximum concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public int? MaxConcurrency { get; set; }

                /// <summary>
                /// <para>The workflow name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myWorkflow</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The workflow status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Disabled.</description></item>
                /// <item><description>1: Enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The time expression. When cron scheduling is used, the Quartz cron format (second minute hour day month week) is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0 12 * * ?</para>
                /// </summary>
                [NameInMap("TimeExpression")]
                [Validation(Required=false)]
                public string TimeExpression { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>-1: None.</description></item>
                /// <item><description>1: Cron.</description></item>
                /// <item><description>100: API.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeType")]
                [Validation(Required=false)]
                public int? TimeType { get; set; }

                /// <summary>
                /// <para>The time zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HangKong</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1963096506470832</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

                /// <summary>
                /// <para>The workflow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public long? WorkflowId { get; set; }

                /// <summary>
                /// <para>The extended attributes.</para>
                /// <remarks>
                /// <para>Not supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("Xattrs")]
                [Validation(Required=false)]
                public string Xattrs { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39938688-0BAB-5AD8-BF02-F4910FAC7589</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
