// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListFunctionInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. If no error occurs, the parameter is left empty.</para>
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
        /// <para>The error message. If no error occurs, the parameter is left empty.</para>
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
        /// <para>A4D487A9-A456-5AA5-A9C6-B7BF2889CF74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListFunctionInstancesResponseBodyResult> Result { get; set; }
        public class ListFunctionInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The information about the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Belongs")]
            [Validation(Required=false)]
            public ListFunctionInstancesResponseBodyResultBelongs Belongs { get; set; }
            public class ListFunctionInstancesResponseBodyResultBelongs : TeaModel {
                /// <summary>
                /// <para>The category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;general&quot;</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The industry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;ecommerce&quot;</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The abbreviation of the language that applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;zh&quot;</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("CreateParameters")]
            [Validation(Required=false)]
            public List<ListFunctionInstancesResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class ListFunctionInstancesResponseBodyResultCreateParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;param1&quot;</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;value1&quot;</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the instance was created.</para>
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
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot; &quot;</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The extended information, which is a JSON string. It includes model evaluation information and error information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;dataReport\&quot;:{},\&quot;errors\&quot;:{}}&quot;</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The name of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;ctr&quot;</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The type of the feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;PAAS&quot;</para>
            /// </summary>
            [NameInMap("FunctionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;ctr_test&quot;</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The type of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;tf_checkpoint&quot;</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>How the instance is created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: The instance is created by user.</description></item>
            /// <item><description>builtin: The instance is created by system.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;user&quot;</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The state of the instance. Valid values:</para>
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
            /// <para>The parameters that are used.</para>
            /// </summary>
            [NameInMap("UsageParameters")]
            [Validation(Required=false)]
            public List<ListFunctionInstancesResponseBodyResultUsageParameters> UsageParameters { get; set; }
            public class ListFunctionInstancesResponseBodyResultUsageParameters : TeaModel {
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
            /// <para>123</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

        /// <summary>
        /// <para>The status of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;OK&quot;</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
