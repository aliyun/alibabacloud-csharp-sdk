// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaSqlTemplateView : TeaModel {
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SqlParams")]
        [Validation(Required=false)]
        public string SqlParams { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
