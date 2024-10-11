// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DeleteFilteringAlgorithmResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>936BE457-5D14-4DBD-85AE-176F7BA8D96D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteFilteringAlgorithmResponseBodyResult Result { get; set; }
        public class DeleteFilteringAlgorithmResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the specified filtering table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("algorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <para>The time when the filtering table was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the filtering table was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The metadata of the filtering table.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public DeleteFilteringAlgorithmResponseBodyResultMeta Meta { get; set; }
            public class DeleteFilteringAlgorithmResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The name of the filtering algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("algorithmName")]
                [Validation(Required=false)]
                public string AlgorithmName { get; set; }

                /// <summary>
                /// <para>The category of the filtering algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i2i</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The CRON expression of the scheduled task. Example: 0 0/12 0 \* \*. The value indicates that the task is scheduled at 00:00 and 12:00 every day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0/12 0 * *</para>
                /// </summary>
                [NameInMap("cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>N/A</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("cronEnabled")]
                [Validation(Required=false)]
                public bool? CronEnabled { get; set; }

                /// <summary>
                /// <para>The description of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Training task</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The additional information.</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public DeleteFilteringAlgorithmResponseBodyResultMetaExtInfo ExtInfo { get; set; }
                public class DeleteFilteringAlgorithmResponseBodyResultMetaExtInfo : TeaModel {
                    /// <summary>
                    /// <para>The delimiter that is used to separate items.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>;</para>
                    /// </summary>
                    [NameInMap("itemSeparator")]
                    [Validation(Required=false)]
                    public string ItemSeparator { get; set; }

                    /// <summary>
                    /// <para>The delimiter that is used to separate keys and values.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>;</para>
                    /// </summary>
                    [NameInMap("kvSeparator")]
                    [Validation(Required=false)]
                    public string KvSeparator { get; set; }

                }

                /// <summary>
                /// <para>The type of the metadata.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <para>The name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name01</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table01</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test01</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The threshold.</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public DeleteFilteringAlgorithmResponseBodyResultMetaThreshold Threshold { get; set; }
                public class DeleteFilteringAlgorithmResponseBodyResultMetaThreshold : TeaModel {
                    /// <summary>
                    /// <para>The fluctuation threshold for the loss of the index data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexLossThreshold")]
                    [Validation(Required=false)]
                    public int? IndexLossThreshold { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the size of the index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexSizeThreshold")]
                    [Validation(Required=false)]
                    public int? IndexSizeThreshold { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the data entries in the source table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataRecordThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataRecordThreshold { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the size of the source table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataSizeThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataSizeThreshold { get; set; }

                }

                /// <summary>
                /// <para>The type of the data source. Only MaxCompute is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The state of the filtering table. Valid values: Draft, Running, Offline, and Deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
