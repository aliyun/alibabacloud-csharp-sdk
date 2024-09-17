// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexShrinkRequest : TeaModel {
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public string CategoryIdsShrink { get; set; }

        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public string ColumnsShrink { get; set; }

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSourceShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public string DocumentIdsShrink { get; set; }

        [NameInMap("EmbeddingModelName")]
        [Validation(Required=false)]
        public string EmbeddingModelName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OverlapSize")]
        [Validation(Required=false)]
        public int? OverlapSize { get; set; }

        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public double? RerankMinScore { get; set; }

        [NameInMap("RerankModelName")]
        [Validation(Required=false)]
        public string RerankModelName { get; set; }

        [NameInMap("Separator")]
        [Validation(Required=false)]
        public string Separator { get; set; }

        [NameInMap("SinkInstanceId")]
        [Validation(Required=false)]
        public string SinkInstanceId { get; set; }

        [NameInMap("SinkRegion")]
        [Validation(Required=false)]
        public string SinkRegion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SinkType")]
        [Validation(Required=false)]
        public string SinkType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StructureType")]
        [Validation(Required=false)]
        public string StructureType { get; set; }

    }

}
