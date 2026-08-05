// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class StopOfflineTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D56E988-A189-53A4-A0A6-C8D744B59775</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public StopOfflineTaskResponseBodyResult Result { get; set; }
        public class StopOfflineTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public StopOfflineTaskResponseBodyResultMeta Meta { get; set; }
            public class StopOfflineTaskResponseBodyResultMeta : TeaModel {
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
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            /// <summary>
            /// <para>The node processing parameters.</para>
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
            /// <para>The processing flow operators.</para>
            /// </summary>
            [NameInMap("processors")]
            [Validation(Required=false)]
            public List<StopOfflineTaskResponseBodyResultProcessors> Processors { get; set; }
            public class StopOfflineTaskResponseBodyResultProcessors : TeaModel {
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
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;processor1&quot;</para>
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
                /// <para>The type.</para>
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
            public List<StopOfflineTaskResponseBodyResultSink> Sink { get; set; }
            public class StopOfflineTaskResponseBodyResultSink : TeaModel {
                /// <summary>
                /// <para>The name of the data sink.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table2</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The configuration parameters of the data sink.</para>
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
                /// <para>The schema of the data sink.</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The type of the data sink.</para>
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
            public List<StopOfflineTaskResponseBodyResultSource> Source { get; set; }
            public class StopOfflineTaskResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The datasource config parameters.</para>
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
                /// <para>The schema of the data source.</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The type of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swift</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The node status.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public StopOfflineTaskResponseBodyResultStatus Status { get; set; }
            public class StopOfflineTaskResponseBodyResultStatus : TeaModel {
                /// <summary>
                /// <para>The time when the node was started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the node was stopped.</para>
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
                /// <para>The node status.</para>
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
