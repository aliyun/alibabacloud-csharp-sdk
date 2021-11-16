// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateImportMigrationRequest : TeaModel {
        [NameInMap("CalculateEngineMap")]
        [Validation(Required=false)]
        public string CalculateEngineMap { get; set; }

        [NameInMap("CommitRule")]
        [Validation(Required=false)]
        public string CommitRule { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PackageFile")]
        [Validation(Required=false)]
        public string PackageFile { get; set; }

        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResourceGroupMap")]
        [Validation(Required=false)]
        public string ResourceGroupMap { get; set; }

        [NameInMap("WorkspaceMap")]
        [Validation(Required=false)]
        public string WorkspaceMap { get; set; }

    }

}
