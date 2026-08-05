// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListOfflineTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>786CC01F-0F1D-5FB5-8BFF-B0F3DB289772</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListOfflineTaskResponseBodyResult> Result { get; set; }
        public class ListOfflineTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The task metadata.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public ListOfflineTaskResponseBodyResultMeta Meta { get; set; }
            public class ListOfflineTaskResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The list of labels.</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public List<string> Labels { get; set; }

                /// <summary>
                /// <para>The region ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>jly-fesOffline-172.16.8.133-20912</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2192861158</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

            /// <summary>
            /// <para>The processing pipeline operators.</para>
            /// </summary>
            [NameInMap("Processors")]
            [Validation(Required=false)]
            public List<ListOfflineTaskResponseBodyResultProcessors> Processors { get; set; }
            public class ListOfflineTaskResponseBodyResultProcessors : TeaModel {
                /// <summary>
                /// <para>The input parameters.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public Dictionary<string, string> Input { get; set; }

                /// <summary>
                /// <para>The name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>processor1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The output parameters.</para>
                /// </summary>
                [NameInMap("Output")]
                [Validation(Required=false)]
                public Dictionary<string, string> Output { get; set; }

                /// <summary>
                /// <para>The processor parameters.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>document-analyze</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data sink information.</para>
            /// </summary>
            [NameInMap("Sink")]
            [Validation(Required=false)]
            public List<ListOfflineTaskResponseBodyResultSink> Sink { get; set; }
            public class ListOfflineTaskResponseBodyResultSink : TeaModel {
                /// <summary>
                /// <para>The data sink name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data sink configuration parameters, which are determined by the type.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                /// <summary>
                /// <para>The primary key field of the data sink.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The data sink schema.</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The data sink type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swift</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The data source information.</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public List<ListOfflineTaskResponseBodyResultSource> Source { get; set; }
            public class ListOfflineTaskResponseBodyResultSource : TeaModel {
                /// <summary>
                /// <para>The data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The data source configuration parameters.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public Dictionary<string, string> Parameters { get; set; }

                /// <summary>
                /// <para>The primary key field of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("PrimaryKey")]
                [Validation(Required=false)]
                public string PrimaryKey { get; set; }

                /// <summary>
                /// <para>The data source schema.</para>
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public List<Dictionary<string, string>> Schema { get; set; }

                /// <summary>
                /// <para>The data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The task status.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public ListOfflineTaskResponseBodyResultStatus Status { get; set; }
            public class ListOfflineTaskResponseBodyResultStatus : TeaModel {
                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The monitoring information.</para>
                /// </summary>
                [NameInMap("MetricData")]
                [Validation(Required=false)]
                public Dictionary<string, string> MetricData { get; set; }

                /// <summary>
                /// <para>The task status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the task was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1744941600000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
