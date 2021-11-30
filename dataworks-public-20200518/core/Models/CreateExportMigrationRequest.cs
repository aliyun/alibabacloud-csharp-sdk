// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateExportMigrationRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExportMode")]
        [Validation(Required=false)]
        public string ExportMode { get; set; }

        [NameInMap("ExportObjectStatus")]
        [Validation(Required=false)]
        public string ExportObjectStatus { get; set; }

        [NameInMap("IncrementalSince")]
        [Validation(Required=false)]
        public long? IncrementalSince { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
