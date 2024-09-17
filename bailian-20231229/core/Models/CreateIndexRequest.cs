// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class CreateIndexRequest : TeaModel {
        [NameInMap("CategoryIds")]
        [Validation(Required=false)]
        public List<string> CategoryIds { get; set; }

        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<CreateIndexRequestColumns> Columns { get; set; }
        public class CreateIndexRequestColumns : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            [NameInMap("IsRecall")]
            [Validation(Required=false)]
            public bool? IsRecall { get; set; }

            [NameInMap("IsSearch")]
            [Validation(Required=false)]
            public bool? IsSearch { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public CreateIndexRequestDataSource DataSource { get; set; }
        public class CreateIndexRequestDataSource : TeaModel {
            [NameInMap("CredentialId")]
            [Validation(Required=false)]
            public string CredentialId { get; set; }

            [NameInMap("CredentialKey")]
            [Validation(Required=false)]
            public string CredentialKey { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("IsPrivateLink")]
            [Validation(Required=false)]
            public bool? IsPrivateLink { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("SubPath")]
            [Validation(Required=false)]
            public string SubPath { get; set; }

            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DocumentIds")]
        [Validation(Required=false)]
        public List<string> DocumentIds { get; set; }

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
