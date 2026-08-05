// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class StartOfflineTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CC93E65-6734-5060-BEF7-0EB0A4862BCF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public StartOfflineTaskResponseBodyResult Result { get; set; }
        public class StartOfflineTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public StartOfflineTaskResponseBodyResultMeta Meta { get; set; }
            public class StartOfflineTaskResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The billing specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>small</para>
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public string ComputeResource { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>taskName</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The task processing parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///   &quot;parameter1&quot;: {
            ///        &quot;key&quot;: &quot;value&quot;
            ///     },
            ///     &quot;parameter2&quot;: {
            ///          &quot;key&quot;: &quot;value&quot;
            ///      }
            /// }</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            /// <summary>
            /// <para>The processing operators.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<StartOfflineTaskResponseBodyResultProcessors> Processors { get; set; }
            public class StartOfflineTaskResponseBodyResultProcessors : TeaModel {
                /// <summary>
                /// <para>The input parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;key&quot;: &quot;content&quot;
                /// }</para>
                /// </summary>
                [NameInMap("input")]
                [Validation(Required=false)]
                public Dictionary<string, object> Input { get; set; }

                /// <summary>
                /// <para>The data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>processor1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The processor processing parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;service_id&quot;: &quot;xxx&quot;
                /// }</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The data sink type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document-analyze</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data sink information.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public List<StartOfflineTaskResponseBodyResultSink> Sink { get; set; }
            public class StartOfflineTaskResponseBodyResultSink : TeaModel {
                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>milvus-ali-cn-hangzhou-1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data sink configuration parameters, which are determined by the type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                /// <summary>
                /// <para>The primary key field of the data sink.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("primaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The data sink schema.</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ModuleRelation</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public List<StartOfflineTaskResponseBodyResultSource> Source { get; set; }
            public class StartOfflineTaskResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <para>The data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The datasource config parameters, which are determined by the type.</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                /// <summary>
                /// <para>The primary key field of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("primaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The data source schema.</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swift</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PENDING: In progress.</description></item>
            /// <item><description>SUCCESS: Parsing succeeded.</description></item>
            /// <item><description>FAILED: Parsing failed.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public StartOfflineTaskResponseBodyResultStatus Status { get; set; }
            public class StartOfflineTaskResponseBodyResultStatus : TeaModel {
                /// <summary>
                /// <para>The task start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The task stop time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("deleteTime")]
                [Validation(Required=false)]
                public long? DeleteTime { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

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

    }

}
