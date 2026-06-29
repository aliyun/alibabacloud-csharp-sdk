// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalNodeByOutputNameResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code returned by the backend</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Node details</para>
        /// </summary>
        [NameInMap("NodeInfo")]
        [Validation(Required=false)]
        public GetPhysicalNodeByOutputNameResponseBodyNodeInfo NodeInfo { get; set; }
        public class GetPhysicalNodeByOutputNameResponseBodyNodeInfo : TeaModel {
            /// <summary>
            /// <para>Creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Node creator</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoCreator Creator { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoCreator : TeaModel {
                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Node source</para>
            /// <list type="bullet">
            /// <item><description>DATA_PROCESS: Code development</description></item>
            /// <item><description>BLACK_BOX: Black box</description></item>
            /// <item><description>ONE_ID: Extraction</description></item>
            /// <item><description>PIPELINE: Pipeline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }

            /// <summary>
            /// <para>Node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_2321</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Last modified time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>Node modifier</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoModifier Modifier { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoModifier : TeaModel {
                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Node subtype</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL, etc.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <para>Node owner</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoOwner Owner { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoOwner : TeaModel {
                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Username</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Priority</para>
            /// <list type="bullet">
            /// <item><description>HIGHEST</description></item>
            /// <item><description>HIGH</description></item>
            /// <item><description>MIDDLE</description></item>
            /// <item><description>LOW</description></item>
            /// <item><description>LOWEST</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MIDDLE</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>Project to which the node belongs</para>
            /// </summary>
            [NameInMap("ProjectInfo")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoProjectInfo ProjectInfo { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoProjectInfo : TeaModel {
                /// <summary>
                /// <para>Project ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>1324211</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Project name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Scheduling period type</para>
            /// <list type="bullet">
            /// <item><description>MINUTELY</description></item>
            /// <item><description>HOURLY</description></item>
            /// <item><description>DAILY</description></item>
            /// <item><description>WEEKLY</description></item>
            /// <item><description>MONTHLY</description></item>
            /// <item><description>YEARLY</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <para>Node scheduling status</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Trigger configuration, used to implement field dependencies on logical tables</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;any_success&quot;}</para>
            /// </summary>
            [NameInMap("TriggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
