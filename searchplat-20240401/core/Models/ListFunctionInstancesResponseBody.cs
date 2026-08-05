// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListFunctionInstancesResponseBody : TeaModel {
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
        /// <para>The elapsed time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.108</para>
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
        /// <para>33E4F0CA-F766-5803-B11C-70DC57A5A6E4</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListFunctionInstancesResponseBodyResult> Result { get; set; }
        public class ListFunctionInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ownership information.</para>
            /// </summary>
            [NameInMap("belongs")]
            [Validation(Required=false)]
            public ListFunctionInstancesResponseBodyResultBelongs Belongs { get; set; }
            public class ListFunctionInstancesResponseBodyResultBelongs : TeaModel {
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
                /// <para>The language. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>zh_CN: Chinese (default)</description></item>
                /// <item><description>en_US: English.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>zh_CN</para>
                /// </summary>
                [NameInMap("language")]
                [Validation(Required=false)]
                public string Language { get; set; }

            }

            /// <summary>
            /// <para>The creation parameter body.</para>
            /// </summary>
            [NameInMap("createParameters")]
            [Validation(Required=false)]
            public List<ListFunctionInstancesResponseBodyResultCreateParameters> CreateParameters { get; set; }
            public class ListFunctionInstancesResponseBodyResultCreateParameters : TeaModel {
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
            /// <para>1713352442039</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The cron expression for the timed scheduling node.</para>
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
            /// <para>The configuration item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nl2sql</para>
            /// </summary>
            [NameInMap("functionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <para>The configuration type.</para>
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
            /// <para>a_test</para>
            /// </summary>
            [NameInMap("instanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The model type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ops-query-analyze-001</para>
            /// </summary>
            [NameInMap("modelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>The instance source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>builtin: system instance</description></item>
            /// <item><description>user: user instance (default)</description></item>
            /// <item><description>all: all instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
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
            /// <para>usageParameters</para>
            /// </summary>
            [NameInMap("usageParameters")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> UsageParameters { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
