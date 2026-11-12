// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListExecutorGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The total count of data under the current request conditions. This parameter is optional and is not returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExecutorGroupResponseBodyData Data { get; set; }
        public class ListExecutorGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
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
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ListExecutorGroupResponseBodyDataRecords> Records { get; set; }
            public class ListExecutorGroupResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The client key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f/HElmWgOgmb0mlbRRkNuQ==</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <para>The authentication type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api_key</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable <b>automatic start and stop</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Enabled. If no tasks are scheduled for a period of time, the agent automatically hibernates. If tasks are scheduled for a period of time, the agent wakes up in advance.</description></item>
                /// <item><description>false: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoScale")]
                [Validation(Required=false)]
                public bool? AutoScale { get; set; }

                /// <summary>
                /// <para>The list of referenced applications.</para>
                /// </summary>
                [NameInMap("CiteList")]
                [Validation(Required=false)]
                public List<ListExecutorGroupResponseBodyDataRecordsCiteList> CiteList { get; set; }
                public class ListExecutorGroupResponseBodyDataRecordsCiteList : TeaModel {
                    /// <summary>
                    /// <para>The name of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Tornado</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <para>The description of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>group1</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }

                /// <summary>
                /// <para>The CloudMonitor workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scx-workspace-acd09a5d-4133-43cc-889d-c33a122afb6e</para>
                /// </summary>
                [NameInMap("CmsWorkspaceId")]
                [Validation(Required=false)]
                public string CmsWorkspaceId { get; set; }

                /// <summary>
                /// <para>The current number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("CurrentJobs")]
                [Validation(Required=false)]
                public int? CurrentJobs { get; set; }

                /// <summary>
                /// <para>The description of the executor group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my first workflow</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EnableJobs")]
                [Validation(Required=false)]
                public int? EnableJobs { get; set; }

                /// <summary>
                /// <para>The integration method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>manual</description></item>
                /// <item><description>acs_sandbox</description></item>
                /// <item><description>k8s_service</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs_sandbox</para>
                /// </summary>
                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// <para>The maximum number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxJobs")]
                [Validation(Required=false)]
                public int? MaxJobs { get; set; }

                /// <summary>
                /// <para>The name of the executor group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The network configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <para>The protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>openai</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The list of resolved workers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;address&quot;:&quot;<a href="http://192.168.2.34:8084%22%7D%5D">http://192.168.2.34:8084&quot;}]</a></para>
                /// </summary>
                [NameInMap("ResolvedWorkers")]
                [Validation(Required=false)]
                public string ResolvedWorkers { get; set; }

                /// <summary>
                /// <para>The ID of the executor group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("WorkerId")]
                [Validation(Required=false)]
                public long? WorkerId { get; set; }

                /// <summary>
                /// <para>The executor type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s_service</para>
                /// </summary>
                [NameInMap("WorkerType")]
                [Validation(Required=false)]
                public string WorkerType { get; set; }

                /// <summary>
                /// <para>The list of specified machines in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;address&quot;:&quot;<a href="http://47.111.188.191:18789%22%7D%5D">http://47.111.188.191:18789&quot;}]</a></para>
                /// </summary>
                [NameInMap("Workers")]
                [Validation(Required=false)]
                public string Workers { get; set; }

                /// <summary>
                /// <para>The extended parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

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
        /// <para>The maximum number of entries to return for this request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position from which the current call returns data. An empty value indicates that all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which the current call returns data. An empty value indicates that all data has been read. You do not need to specify this parameter for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5EF879D0-3B43-5AD1-9BF7-52418F9C5E73</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
