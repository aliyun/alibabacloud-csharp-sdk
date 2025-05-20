// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class Snapshot : TeaModel {
        [NameInMap("baseManifestList")]
        [Validation(Required=false)]
        public string BaseManifestList { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("changelogManifestList")]
        [Validation(Required=false)]
        public string ChangelogManifestList { get; set; }

        [NameInMap("changelogRecordCount")]
        [Validation(Required=false)]
        public long? ChangelogRecordCount { get; set; }

        [NameInMap("commitIdentifier")]
        [Validation(Required=false)]
        public long? CommitIdentifier { get; set; }

        [NameInMap("commitKind")]
        [Validation(Required=false)]
        public string CommitKind { get; set; }

        [NameInMap("commitUser")]
        [Validation(Required=false)]
        public string CommitUser { get; set; }

        [NameInMap("deltaManifestList")]
        [Validation(Required=false)]
        public string DeltaManifestList { get; set; }

        [NameInMap("deltaRecordCount")]
        [Validation(Required=false)]
        public long? DeltaRecordCount { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("indexManifest")]
        [Validation(Required=false)]
        public string IndexManifest { get; set; }

        [NameInMap("logOffsets")]
        [Validation(Required=false)]
        public Dictionary<string, long?> LogOffsets { get; set; }

        [NameInMap("schemaId")]
        [Validation(Required=false)]
        public long? SchemaId { get; set; }

        [NameInMap("statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        [NameInMap("timeMillis")]
        [Validation(Required=false)]
        public long? TimeMillis { get; set; }

        [NameInMap("totalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        [NameInMap("watermark")]
        [Validation(Required=false)]
        public long? Watermark { get; set; }

    }

}
