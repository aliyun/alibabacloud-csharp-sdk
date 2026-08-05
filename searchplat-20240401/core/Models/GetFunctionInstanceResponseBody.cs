// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class GetFunctionInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>not found</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>The time consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.627</para>
        /// </summary>
        [NameInMap("latency")]
        [Validation(Required=false)]
        public long? Latency { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;xx not found&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C56462F4-CCB3-10BF-A3D8-FEE53C72B65C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFunctionInstanceResponseBodyResult Result { get; set; }
        public class GetFunctionInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ownership information.</para>
            /// </summary>
            [NameInMap("belongs")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultBelongs Belongs { get; set; }
            public class GetFunctionInstanceResponseBodyResultBelongs : TeaModel {
                /// <summary>
                /// <para>The category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The industry type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>The specific configuration items.</para>
            /// </summary>
            [NameInMap("createParameters")]
            [Validation(Required=false)]
            public List<GetFunctionInstanceResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class GetFunctionInstanceResponseBodyResultCreateParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724998630466</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The cron expression for the timed scheduling task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>nl2sql</description></item>
            /// <item><description>embedding-tuning</description></item>
            /// <item><description>deployment</description></item>
            /// <item><description>notebook.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>nl2sql</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The configuration type. PAAS (default): requires training before use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAAS</para>
            /// </summary>
            [NameInMap("functionType")]
            [Validation(Required=false)]
            public string FunctionType { get; set; }

            /// <summary>
            /// <para>The configuration name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The model type. The valid values vary based on the configuration type (functionName):</para>
            /// <list type="bullet">
            /// <item><description>ops-query-analyze-nl2sql-001 (nl2sql)</description></item>
            /// <item><description>ops-embedding-dim-reduction-001 (embedding-tuning)</description></item>
            /// <item><description>native (deployment)</description></item>
            /// <item><description>dsw (notebook).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dsw</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>available</description></item>
            /// <item><description>unavailable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The task information.</para>
            /// </summary>
            [NameInMap("task")]
            [Validation(Required=false)]
            public GetFunctionInstanceResponseBodyResultTask Task { get; set; }
            public class GetFunctionInstanceResponseBodyResultTask : TeaModel {
                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: Succeeded.</description></item>
                /// <item><description>failed: Failed.</description></item>
                /// <item><description>untrained: Pending training.</description></item>
                /// <item><description>pending: Scheduling.</description></item>
                /// <item><description>running: Training in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("dagStatus")]
                [Validation(Required=false)]
                public string DagStatus { get; set; }

                /// <summary>
                /// <para>The last training time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724998630466</para>
                /// </summary>
                [NameInMap("lastRunTime")]
                [Validation(Required=false)]
                public long? LastRunTime { get; set; }

            }

            /// <summary>
            /// <para>The training version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("versionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

        }

        /// <summary>
        /// <para>The request status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
