// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateIndexRequest : TeaModel {
        /// <summary>
        /// <para>The number of most similar text segments to retrieve using vector search. A vector is generated for the input text, and the K most similar text segments are retrieved from the knowledge base. The value of K must be in the range of 0 to 100.
        /// The sum of <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> cannot exceed 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        /// <summary>
        /// <para>The description of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业知识库</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The knowledge base ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业帮助文档库</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of Retrieval Compute Units (RCUs) for the Ultimate Edition knowledge base. This parameter is required only when PipelineCommercialType is set to enterprise.</para>
        /// <para>The value must be in the range of 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PipelineCommercialCu")]
        [Validation(Required=false)]
        public int? PipelineCommercialCu { get; set; }

        /// <summary>
        /// <para>The edition of the knowledge base. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>standard: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>enterprise: Ultimate Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("PipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <para>The minimum score for sorting. The value must be between 0 and 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public string RerankMinScore { get; set; }

        /// <summary>
        /// <para>The number of text segments to retrieve using an exact keyword match. This helps filter out irrelevant text segments and provides more accurate results.
        /// The value must be in the range of 0 to 100.
        /// The sum of <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> cannot exceed 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
