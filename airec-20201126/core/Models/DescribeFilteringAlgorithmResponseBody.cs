// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class DescribeFilteringAlgorithmResponseBody : TeaModel {
        /// <summary>
        /// <para>The metadata of the filtering table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7585C2B2-0D61-4C96-AC5D-B960BFEDD4A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeFilteringAlgorithmResponseBodyResult Result { get; set; }
        public class DescribeFilteringAlgorithmResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The fluctuation threshold for the size of the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("algorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <para>The category of the filtering table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The name of the project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The time when the filtering table was modified.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public DescribeFilteringAlgorithmResponseBodyResultMeta Meta { get; set; }
            public class DescribeFilteringAlgorithmResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The time when the filtering table was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("algorithmName")]
                [Validation(Required=false)]
                public string AlgorithmName { get; set; }

                /// <summary>
                /// <para>Indicates whether the scheduled task is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1_2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>N/A</para>
                /// 
                /// <b>Example:</b>
                /// <para>244</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The information about the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description><list type="bullet">
                /// <item><description>24 7 0</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The ID of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cronEnabled")]
                [Validation(Required=false)]
                public bool? CronEnabled { get; set; }

                /// <summary>
                /// <para>The time when the filtering table was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the task.</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public DescribeFilteringAlgorithmResponseBodyResultMetaExtInfo ExtInfo { get; set; }
                public class DescribeFilteringAlgorithmResponseBodyResultMetaExtInfo : TeaModel {
                    /// <summary>
                    /// <para>The description of the filtering table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>,</para>
                    /// </summary>
                    [NameInMap("itemSeparator")]
                    [Validation(Required=false)]
                    public string ItemSeparator { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the size of the index.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>:</para>
                    /// </summary>
                    [NameInMap("kvSeparator")]
                    [Validation(Required=false)]
                    public string KvSeparator { get; set; }

                }

                /// <summary>
                /// <para>The information about the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>metaType</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <para>The status of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The ID of the specified filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The CRON expression of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>taskId</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The ID of the filtering table.</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public DescribeFilteringAlgorithmResponseBodyResultMetaThreshold Threshold { get; set; }
                public class DescribeFilteringAlgorithmResponseBodyResultMetaThreshold : TeaModel {
                    /// <summary>
                    /// <para>The ID of the specified instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexLossThreshold")]
                    [Validation(Required=false)]
                    public int? IndexLossThreshold { get; set; }

                    /// <summary>
                    /// <para>Queries specific configuration information about a filtering table based on the ID of the filtering table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexSizeThreshold")]
                    [Validation(Required=false)]
                    public int? IndexSizeThreshold { get; set; }

                    /// <summary>
                    /// <para>The type of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataRecordThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataRecordThreshold { get; set; }

                    /// <summary>
                    /// <para>The name of the filtering table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataSizeThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataSizeThreshold { get; set; }

                }

                /// <summary>
                /// <para>The metadata of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>N/A</para>
            /// 
            /// <b>Example:</b>
            /// <para>The threshold for the loss of the index data.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
