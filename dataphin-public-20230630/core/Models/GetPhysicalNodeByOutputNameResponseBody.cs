// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalNodeByOutputNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request is normal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The node details.</para>
        /// </summary>
        [NameInMap("NodeInfo")]
        [Validation(Required=false)]
        public GetPhysicalNodeByOutputNameResponseBodyNodeInfo NodeInfo { get; set; }
        public class GetPhysicalNodeByOutputNameResponseBodyNodeInfo : TeaModel {
            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the node.</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoCreator Creator { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoCreator : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The node source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DATA_PROCESS: code development</description></item>
            /// <item><description>BLACK_BOX: black box</description></item>
            /// <item><description>ONE_ID: extraction</description></item>
            /// <item><description>PIPELINE: pipeline</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("From")]
            [Validation(Required=false)]
            public string From { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_2321</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717343597000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The modifier of the node.</para>
            /// </summary>
            [NameInMap("Modifier")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoModifier Modifier { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoModifier : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The node subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MAX_COMPUTE_SQL</description></item>
            /// <item><description>HIVE_SQL</description></item>
            /// <item><description>SHELL</description></item>
            /// <item><description>PYTHON</description></item>
            /// <item><description>ONE_SERVICE_SQL</description></item>
            /// <item><description>DATABASE_SQL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <para>The owner of the node.</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoOwner Owner { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoOwner : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1311131</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The priority. Valid values:</para>
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
            /// <para>The project to which the node belongs.</para>
            /// </summary>
            [NameInMap("ProjectInfo")]
            [Validation(Required=false)]
            public GetPhysicalNodeByOutputNameResponseBodyNodeInfoProjectInfo ProjectInfo { get; set; }
            public class GetPhysicalNodeByOutputNameResponseBodyNodeInfoProjectInfo : TeaModel {
                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1324211</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The scheduling cycle type. Valid values:</para>
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
            /// <para>The scheduling status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The trigger configuration, which is used to implement field dependencies for logical tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;any_success&quot;}</para>
            /// </summary>
            [NameInMap("TriggerConfig")]
            [Validation(Required=false)]
            public string TriggerConfig { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
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
