// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeKnowledgeBaseFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of files.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeKnowledgeBaseFilesResponseBodyItems> Items { get; set; }
        public class DescribeKnowledgeBaseFilesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Not Support.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The file ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5b2dbb13-xxxx-xxxx-xxxx-a55fe8daec8f</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Financial_report.pdf</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The file size, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>318881</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <para>Indicates whether the chunking strategy is inherited from the knowledge space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InheritSpaceStrategy")]
            [Validation(Required=false)]
            public bool? InheritSpaceStrategy { get; set; }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pkb-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The knowledge space ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pks-xxxxxx</para>
            /// </summary>
            [NameInMap("KnowledgeSpaceId")]
            [Validation(Required=false)]
            public string KnowledgeSpaceId { get; set; }

            /// <summary>
            /// <para>The document metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The OSS file path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket-example/pks-xxxx/pkb-xxxx/Financial_report.pdf</para>
            /// </summary>
            [NameInMap("OSSPath")]
            [Validation(Required=false)]
            public string OSSPath { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ShardCount")]
            [Validation(Required=false)]
            public int? ShardCount { get; set; }

            /// <summary>
            /// <para>The chunking strategy configuration currently in effect for the document. This value may be empty if the complete configuration was not saved for existing objects.</para>
            /// </summary>
            [NameInMap("ShardingStrategyConfig")]
            [Validation(Required=false)]
            public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfig ShardingStrategyConfig { get; set; }
            public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfig : TeaModel {
                /// <summary>
                /// <para>The default chunking strategy type. Valid values: hybrid and hierarchical.</para>
                /// </summary>
                [NameInMap("DefaultStrategy")]
                [Validation(Required=false)]
                public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategy DefaultStrategy { get; set; }
                public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategy : TeaModel {
                    /// <summary>
                    /// <para>The parameter list.</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategyParameters Parameters { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigDefaultStrategyParameters : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of tokens per shard.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>512</para>
                        /// </summary>
                        [NameInMap("MaxTokens")]
                        [Validation(Required=false)]
                        public int? MaxTokens { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to merge adjacent small shards under the same heading.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("MergePeers")]
                        [Validation(Required=false)]
                        public bool? MergePeers { get; set; }

                    }

                    /// <summary>
                    /// <para>The default chunking strategy type. Valid values: hybrid and hierarchical.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hybrid</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The list of override rules matched in order.</para>
                /// </summary>
                [NameInMap("Rules")]
                [Validation(Required=false)]
                public List<DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRules> Rules { get; set; }
                public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRules : TeaModel {
                    /// <summary>
                    /// <para>The content type. Currently, table is supported.</para>
                    /// </summary>
                    [NameInMap("Match")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesMatch Match { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesMatch : TeaModel {
                        /// <summary>
                        /// <para>The content type. Currently, table is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>table</para>
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    /// <summary>
                    /// <para>The chunking strategy.</para>
                    /// </summary>
                    [NameInMap("Strategy")]
                    [Validation(Required=false)]
                    public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategy Strategy { get; set; }
                    public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategy : TeaModel {
                        /// <summary>
                        /// <para>The parameter list.</para>
                        /// </summary>
                        [NameInMap("Parameters")]
                        [Validation(Required=false)]
                        public DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategyParameters Parameters { get; set; }
                        public class DescribeKnowledgeBaseFilesResponseBodyItemsShardingStrategyConfigRulesStrategyParameters : TeaModel {
                            /// <summary>
                            /// <para>The Markdown table processing mode. Valid values: auto, on, and off.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>auto</para>
                            /// </summary>
                            [NameInMap("MarkdownTables")]
                            [Validation(Required=false)]
                            public string MarkdownTables { get; set; }

                            /// <summary>
                            /// <para>The maximum number of tokens per shard for matched content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>512</para>
                            /// </summary>
                            [NameInMap("MaxTokens")]
                            [Validation(Required=false)]
                            public int? MaxTokens { get; set; }

                        }

                        /// <summary>
                        /// <para>The chunking strategy type applied after a rule is matched.</para>
                        /// 
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
            /// <para>The source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-15T22:28:53Z</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The upload time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-15T22:28:53Z</para>
            /// </summary>
            [NameInMap("UploadTime")]
            [Validation(Required=false)]
            public string UploadTime { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CED079B7-A408-41A1-BFF1-EC608E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
