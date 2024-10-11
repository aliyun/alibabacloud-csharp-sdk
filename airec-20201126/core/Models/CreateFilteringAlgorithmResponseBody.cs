// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class CreateFilteringAlgorithmResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>829F38F6-E2D6-4109-90A6-888160BD16C2</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values: true: performs a dry run. false: performs a dry run and sends the request.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateFilteringAlgorithmResponseBodyResult Result { get; set; }
        public class CreateFilteringAlgorithmResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("algorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <para>The time when the filtering table was created. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The fluctuation threshold for the data entries in the source table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The threshold.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public CreateFilteringAlgorithmResponseBodyResultMeta Meta { get; set; }
            public class CreateFilteringAlgorithmResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <para>The name of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>algorithmTest</para>
                /// </summary>
                [NameInMap("algorithmName")]
                [Validation(Required=false)]
                public string AlgorithmName { get; set; }

                /// <summary>
                /// <para>The response body.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1_2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The fluctuation threshold for the size of the index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0 0/12 0 * *</para>
                /// </summary>
                [NameInMap("cron")]
                [Validation(Required=false)]
                public string Cron { get; set; }

                /// <summary>
                /// <para>The time when the filtering table was last modified. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed UTC.</para>
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
                /// <para>xx</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtInfo { get; set; }

                /// <summary>
                /// <para>The information about the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-07T02:24:26.000Z</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>Indicates whether the scheduled task is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-12-07T02:24:26.000Z</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testname</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The CRON expression of the scheduled task. Example: 0 0/12 0 \* \*, which indicates that the task is scheduled at 00:00 and 12:00 every day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The metadata of the filtering table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_test</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>0 0/12 0 * *&quot;</para>
                /// </summary>
                [NameInMap("threshold")]
                [Validation(Required=false)]
                public CreateFilteringAlgorithmResponseBodyResultMetaThreshold Threshold { get; set; }
                public class CreateFilteringAlgorithmResponseBodyResultMetaThreshold : TeaModel {
                    /// <summary>
                    /// <para>The time when the filtering table was modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexLossThreshold")]
                    [Validation(Required=false)]
                    public int? IndexLossThreshold { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the size of the source table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexSizeThreshold")]
                    [Validation(Required=false)]
                    public int? IndexSizeThreshold { get; set; }

                    /// <summary>
                    /// <para>The category of the filtering table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataRecordThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataRecordThreshold { get; set; }

                    /// <summary>
                    /// <para>The fluctuation threshold for the loss of the index data.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataSizeThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataSizeThreshold { get; set; }

                }

                /// <summary>
                /// <para>The ID of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the filtering algorithm.</para>
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
