// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLDatabase : TeaModel {
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long? DbId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
