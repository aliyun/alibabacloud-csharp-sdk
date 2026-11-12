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
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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

            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyDataRecords> Records { get; set; }
            public class ListAppsResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The access token.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2f4ddeab8e344ed68e0402cf9b8502ffv3</para>
                /// </summary>
                [NameInMap("AccessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

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
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1827811800555555</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Indicates whether logging is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableLog")]
                [Validation(Required=false)]
                public bool? EnableLog { get; set; }

                /// <summary>
                /// <para>The number of executors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecutorNum")]
                [Validation(Required=false)]
                public long? ExecutorNum { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>43885</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("JobNum")]
                [Validation(Required=false)]
                public int? JobNum { get; set; }

                /// <summary>
                /// <para>The label routing strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LabelRouteStrategy")]
                [Validation(Required=false)]
                public int? LabelRouteStrategy { get; set; }

                /// <summary>
                /// <para>The leader address.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://28.***.***.3:80">http://28.***.***.3:80</a></para>
                /// </summary>
                [NameInMap("Leader")]
                [Validation(Required=false)]
                public string Leader { get; set; }

                /// <summary>
                /// <para>The maximum concurrency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxConcurrency")]
                [Validation(Required=false)]
                public int? MaxConcurrency { get; set; }

                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>The maximum number of jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                [Obsolete]
                public int? MaxJobs { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test application</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1827811800555555</para>
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
                /// <para>The manually registered executor type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s_service</para>
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
            /// <para>The total count.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Parameter error: content is null.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C3E52FF-CBE9-5C0E-8252-37ACFF1F5EFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
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
