// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateOfflineTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7C901ED-2BC1-5CFB-BE23-242DE5E3BA5C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOfflineTaskResponseBodyResult Result { get; set; }
        public class CreateOfflineTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The task metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public CreateOfflineTaskResponseBodyResultMeta Meta { get; set; }
            public class CreateOfflineTaskResponseBodyResultMeta : TeaModel {
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
                /// <para>test</para>
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
            /// &quot;parameter1&quot;: {
            /// &quot;key&quot;: &quot;value&quot;
            /// },
            /// &quot;parameter2&quot;: {
            /// &quot;key&quot;: &quot;value&quot;
            /// }
            /// }</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, object> Parameters { get; set; }

            /// <summary>
            /// <para>The processing pipeline operators.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<CreateOfflineTaskResponseBodyResultProcessors> Processors { get; set; }
            public class CreateOfflineTaskResponseBodyResultProcessors : TeaModel {
                /// <summary>
                /// <para>The input parameters.</para>
                /// </summary>
                [NameInMap("input")]
                [Validation(Required=false)]
                public Dictionary<string, object> Input { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;processor1&quot;</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The processor parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                /// &quot;service_id&quot;: &quot;xxx&quot;
                /// }</para>
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;document-analyze&quot;</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The output destination information.</para>
            /// </summary>
            [NameInMap("sink")]
            [Validation(Required=false)]
            public List<CreateOfflineTaskResponseBodyResultSink> Sink { get; set; }
            public class CreateOfflineTaskResponseBodyResultSink : TeaModel {
                /// <summary>
                /// <para>The data sink name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table2</para>
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
                /// <para>The data sink type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swift</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data source information.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public List<CreateOfflineTaskResponseBodyResultSource> Source { get; set; }
            public class CreateOfflineTaskResponseBodyResultSource : TeaModel {
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
            /// <para>The task status.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public CreateOfflineTaskResponseBodyResultStatus Status { get; set; }
            public class CreateOfflineTaskResponseBodyResultStatus : TeaModel {
                /// <summary>
                /// <para>The task start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The task stop time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("deleteTime")]
                [Validation(Required=false)]
                public string DeleteTime { get; set; }

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
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
