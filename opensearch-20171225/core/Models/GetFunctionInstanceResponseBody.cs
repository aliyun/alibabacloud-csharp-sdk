// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class GetFunctionInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. If no error occurs, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance.NotExist</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The time consumed for the request, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68ED4E1B-92B8-5821-A886-9C90686139EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetFunctionInstanceResponseBodyResult Result { get; set; }
        public class GetFunctionInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The information about the instance.</para>
            /// </summary>
            [NameInMap("Belongs")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultBelongs Belongs { get; set; }
            public class GetFunctionInstanceResponseBodyResultBelongs : TeaModel {
                /// <summary>
                /// <para>The category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecommerce</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The abbreviation of the language that applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are used to create the instance.</para>
            /// </summary>
            [NameInMap("CreateParameters")]
            [Validation(Required=false)]
            public List<GetFunctionInstanceResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class GetFunctionInstanceResponseBodyResultCreateParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the task was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The cron expression used to schedule training, in the format of (Minutes Hours DayofMonth Month DayofWeek). If the value is empty, it indicates that no periodic training is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 3 ? \* 0,1,3,5 (at 3 a.m. on Sunday, Monday, Wednesday, and Friday)</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance descriptions</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The extended information, which is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;dataReport\&quot;:{},\&quot;errors\&quot;:{}}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctr</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The type of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAAS</para>
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ctr_test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tf_checkpoint</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>How the instance is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: The instance is created by user.</description></item>
            /// <item><description>builtin: The instance is created by the system.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <ol>
            /// <item><description>unavailable: No model is available. Models must be trained before you can use them.</description></item>
            /// <item><description>available: Models can be used.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The information about the training task. This parameter is not displayed if no task is available.</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultTask Task { get; set; }
            public class GetFunctionInstanceResponseBodyResultTask : TeaModel {
                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: succeeded</description></item>
                /// <item><description>failed: failed</description></item>
                /// <item><description>untrained: to be trained</description></item>
                /// <item><description>pending: being scheduled</description></item>
                /// <item><description>running: being trained</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("DagStatus")]
                [Validation(Required=false)]
                public string DagStatus { get; set; }

                /// <summary>
                /// <para>The time consumed for the most recent run, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("LastRunTime")]
                [Validation(Required=false)]
                public long? LastRunTime { get; set; }

            }

            /// <summary>
            /// <para>The parameters that are used.</para>
            /// </summary>
            [NameInMap("UsageParameters")]
            [Validation(Required=false)]
            public List<GetFunctionInstanceResponseBodyResultUsageParameters> UsageParameters { get; set; }
            public class GetFunctionInstanceResponseBodyResultUsageParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>use_param1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

        /// <summary>
        /// <para>The status of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
