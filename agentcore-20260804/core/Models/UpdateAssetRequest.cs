// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAssetRequest : TeaModel {
        /// <summary>
        /// <para>At least one of the following parameters must be provided: name, enabled, metadata, or chunkConfiguration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAssetRequestBody Body { get; set; }
        public class UpdateAssetRequestBody : TeaModel {
            /// <summary>
            /// <para>In Phase 1, only AUTO and BY_SEPARATOR are supported, and maxChunkSize ranges from 1 to 6,000 characters. In the UPLOADING state, only the configuration snapshot is updated and used after the upload is confirmed. In the COMPLETED state, the asset is asynchronously reparsed, chunked, and vectorized according to the new policy. Rebuilding chunks overwrites manual text and start/stop modifications. The FAILED state does not support retries. The PENDING, PROCESSING, DELETING, and DELETED states also return InvalidAssetState. Before asynchronous processing succeeds and conditional publication occurs, old results must still pass validation against current permissions, enabled status, and deletion status. If enabled=false is included in the same request, regular reading is stopped immediately.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;strategy&quot;:&quot;AUTO&quot;,&quot;maxChunkSize&quot;:1000}</para>
            /// </summary>
            [NameInMap("chunkConfiguration")]
            [Validation(Required=false)]
            public UpdateAssetRequestBodyChunkConfiguration ChunkConfiguration { get; set; }
            public class UpdateAssetRequestBodyChunkConfiguration : TeaModel {
                /// <summary>
                /// <para>Required when the strategy is BY_HEADING, and the value ranges from 1 to 6. Headings at or above this level are used as boundaries. Deeper headings are retained in the text. Overlong sections fall back to paragraph or sentence chunking, and documents without headings fall back to intelligent chunking. It is ignored for other strategies and validated by the backend according to the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("headingLevel")]
                [Validation(Required=false)]
                public int? HeadingLevel { get; set; }

                /// <summary>
                /// <para>Ranges from 1 to 6,000 characters. It uses the character length metric of EB and is not the number of tokens. If omitted, the server default value is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512</para>
                /// </summary>
                [NameInMap("maxChunkSize")]
                [Validation(Required=false)]
                public int? MaxChunkSize { get; set; }

                /// <summary>
                /// <para>Takes effect only when the strategy is BY_LENGTH. The unit is characters, and the default value is 0. The valid value must be greater than or equal to 0 and less than the valid maxChunkSize, and the length after overlapping must not exceed the maximum chunk size. It is ignored for other strategies and validated by the backend according to the strategy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("overlapSize")]
                [Validation(Required=false)]
                public int? OverlapSize { get; set; }

                /// <summary>
                /// <para>The text preprocessing rules applied before chunking.</para>
                /// </summary>
                [NameInMap("preprocessRules")]
                [Validation(Required=false)]
                public UpdateAssetRequestBodyChunkConfigurationPreprocessRules PreprocessRules { get; set; }
                public class UpdateAssetRequestBodyChunkConfigurationPreprocessRules : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to remove URLs and email addresses during parsing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("removeUrlsAndEmails")]
                    [Validation(Required=false)]
                    public bool? RemoveUrlsAndEmails { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to replace consecutive spaces, line breaks, and tabs with a single space.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("replaceConsecutiveWhitespace")]
                    [Validation(Required=false)]
                    public bool? ReplaceConsecutiveWhitespace { get; set; }

                }

                /// <summary>
                /// <para>Required and non-empty when the strategy is BY_SEPARATOR. It matches the literal string as a whole and does not use regular expressions. It is ignored for other strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\n\n</para>
                /// </summary>
                [NameInMap("separator")]
                [Validation(Required=false)]
                public string Separator { get; set; }

                /// <summary>
                /// <para>The saved chunking strategy. AUTO indicates automatic chunking, and BY_SEPARATOR indicates chunking by separator. BY_LENGTH and BY_HEADING are returned only for compatibility with historical configurations. When creating or updating a configuration in Phase 1, only AUTO and BY_SEPARATOR are accepted.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AUTO</para>
                /// </summary>
                [NameInMap("strategy")]
                [Validation(Required=false)]
                public string Strategy { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the asset is enabled. When set to false, the asset is excluded from regular viewing, retrieval, and downloading.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Only fields declared in the metadataSchema are allowed. Fields are incrementally merged by key, and unprovided keys are retained. Omitting the value, setting it to null, or setting it to an empty string indicates that the key is deleted. An empty array does not modify any keys. Fixed-value or system variable fields cannot be overwritten or deleted by users, and the backend rejects such modifications. Changes that affect retrieval projections are published with the new generation. Before publication, old results are still validated against current permissions, enabled status, and deletion status. When submitted together with chunkConfiguration, new chunks use the merged metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;key&quot;:&quot;category&quot;,&quot;value&quot;:&quot;manual&quot;}]</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public List<UpdateAssetRequestBodyMetadata> Metadata { get; set; }
            public class UpdateAssetRequestBodyMetadata : TeaModel {
                /// <summary>
                /// <para>The name of the field declared in the metadataSchema. It must be unique within the same request. Fixed-value and system variable fields are generated by the server and cannot be overwritten by users.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The string parsed according to the schema type. Omitting the value or providing an empty value during upload indicates that no value is assigned, and the value is populated by the schema. In UpdateAsset, omitting the value, setting it to null, or setting it to an empty string indicates that the key is deleted, and unsubmitted keys remain unchanged. For DATETIME, ISO 8601 format with time zone, yyyy-MM-dd HH:mm:ss, or yyyy-MM-dd is accepted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>engineering</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The updated display name. It can be up to 255 characters in length and does not change the content of the original file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product User Guide</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
