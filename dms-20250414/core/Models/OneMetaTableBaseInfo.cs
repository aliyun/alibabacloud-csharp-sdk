// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaTableBaseInfo : TeaModel {
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EngineMeta")]
        [Validation(Required=false)]
        public OneMetaTableEngineMeta EngineMeta { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

        [NameInMap("TableUuid")]
        [Validation(Required=false)]
        public string TableUuid { get; set; }

    }

}
