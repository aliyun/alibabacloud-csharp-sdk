// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListExecutorGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListExecutorGroupResponseBodyData Data { get; set; }
        public class ListExecutorGroupResponseBodyData : TeaModel {
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
            public List<ListExecutorGroupResponseBodyDataRecords> Records { get; set; }
            public class ListExecutorGroupResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>f/HElmWgOgmb0mlbRRkNuQ==</para>
                /// </summary>
                [NameInMap("ApiKey")]
                [Validation(Required=false)]
                public string ApiKey { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>api_key</para>
                /// </summary>
                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("AutoScale")]
                [Validation(Required=false)]
                public bool? AutoScale { get; set; }

                [NameInMap("CiteList")]
                [Validation(Required=false)]
                public List<ListExecutorGroupResponseBodyDataRecordsCiteList> CiteList { get; set; }
                public class ListExecutorGroupResponseBodyDataRecordsCiteList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Tornado</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>group1</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                }

                [NameInMap("CmsWorkspaceId")]
                [Validation(Required=false)]
                public string CmsWorkspaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>my first workflow</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IntegrationType")]
                [Validation(Required=false)]
                public string IntegrationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Network")]
                [Validation(Required=false)]
                public string Network { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>openai</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("ResolvedWorkers")]
                [Validation(Required=false)]
                public string ResolvedWorkers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("WorkerId")]
                [Validation(Required=false)]
                public long? WorkerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>k8s_service</para>
                /// </summary>
                [NameInMap("WorkerType")]
                [Validation(Required=false)]
                public string WorkerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;address&quot;:&quot;<a href="http://47.111.188.191:18789%22%7D%5D">http://47.111.188.191:18789&quot;}]</a></para>
                /// </summary>
                [NameInMap("Workers")]
                [Validation(Required=false)]
                public string Workers { get; set; }

                [NameInMap("XAttrs")]
                [Validation(Required=false)]
                public string XAttrs { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter check error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
