// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ModifyFilteringAlgorithmMetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7585C2B2-0D61-4C96-AC5D-B960BFEDD4A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public ModifyFilteringAlgorithmMetaResponseBodyResult Result { get; set; }
        public class ModifyFilteringAlgorithmMetaResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("algorithmId")]
            [Validation(Required=false)]
            public string AlgorithmId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-12-07T02:24:26.000Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public ModifyFilteringAlgorithmMetaResponseBodyResultMeta Meta { get; set; }
            public class ModifyFilteringAlgorithmMetaResponseBodyResultMeta : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("algorithmName")]
                [Validation(Required=false)]
                public string AlgorithmName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1_2</para>
                /// </summary>
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>244</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
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

                [NameInMap("cronEnabled")]
                [Validation(Required=false)]
                public bool? CronEnabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("extInfo")]
                [Validation(Required=false)]
                public ModifyFilteringAlgorithmMetaResponseBodyResultMetaExtInfo ExtInfo { get; set; }
                public class ModifyFilteringAlgorithmMetaResponseBodyResultMetaExtInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>,</para>
                    /// </summary>
                    [NameInMap("itemSeparator")]
                    [Validation(Required=false)]
                    public string ItemSeparator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>:</para>
                    /// </summary>
                    [NameInMap("kvSeparator")]
                    [Validation(Required=false)]
                    public string KvSeparator { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>metaType</para>
                /// </summary>
                [NameInMap("metaType")]
                [Validation(Required=false)]
                public string MetaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_table</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>taskId</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("threshold")]
                [Validation(Required=false)]
                public ModifyFilteringAlgorithmMetaResponseBodyResultMetaThreshold Threshold { get; set; }
                public class ModifyFilteringAlgorithmMetaResponseBodyResultMetaThreshold : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexLossThreshold")]
                    [Validation(Required=false)]
                    public int? IndexLossThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("indexSizeThreshold")]
                    [Validation(Required=false)]
                    public int? IndexSizeThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataRecordThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataRecordThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("sourceDataSizeThreshold")]
                    [Validation(Required=false)]
                    public int? SourceDataSizeThreshold { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ODPS</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
