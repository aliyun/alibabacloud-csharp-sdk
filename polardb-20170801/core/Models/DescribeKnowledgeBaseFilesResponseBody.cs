// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseFilesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseFilesResponseBodyItems> Items { get; set; }
        public class DescribeKnowledgeBaseFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Not Support.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5b2dbb13-xxxx-xxxx-xxxx-a55fe8daec8f</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>财报.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>318881</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InheritSpaceStrategy")]
            [Validation(Required=false)]
            public bool? InheritSpaceStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pkb-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pks-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeSpaceId")]
            [Validation(Required=false)]
            public string KnowledgeSpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket-example/pks-xxxx/pkb-xxxx/财报.pdf</para>
            /// </summary>
            [NameInMap("OSSPath")]
            [Validation(Required=false)]
            public string OSSPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            [NameInMap("ShardingStrategyConfig")]
            [Validation(Required=false)]
            public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfig ShardingStrategyConfig { get; set; }
            public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfig : TeaModel {
                [NameInMap("DefaultStrategy")]
                [Validation(Required=false)]
                public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
                public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategy : TeaModel {
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("MergePeers")]
                        [Validation(Required=false)]
                        public bool? MergePeers { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hybrid</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRules> Rules { get; set; }
                public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRules : TeaModel {
                    [NameInMap("Match")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesMatch Match { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesMatch : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>table</para>
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    [NameInMap("Strategy")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategy Strategy { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategy : TeaModel {
                        [NameInMap("Parameters")]
                        [Validation(Required=false)]
                        public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                        public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategyParameters : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>auto</para>
                            /// </summary>
                            [NameInMap("MarkdownTables")]
                            [Validation(Required=false)]
                            public string MarkdownTables { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>512</para>
                            /// </summary>
                            [NameInMap("MaxTokens")]
                            [Validation(Required=false)]
                            public int? MaxTokens { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>hierarchical</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-06-15T22:28:53Z</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-06-15T22:28:53Z</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CED079B7-A408-41A1-BFF1-EC608E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
