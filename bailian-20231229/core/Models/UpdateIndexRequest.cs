// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateIndexRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79c0alxxxx</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PipelineCommercialCu")]
        [Validation(Required=false)]
        public int? PipelineCommercialCu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("PipelineCommercialType")]
        [Validation(Required=false)]
        public string PipelineCommercialType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.01</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public string RerankMinScore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
