// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class Function : TeaModel {
        [NameInMap("CatalogId")]
        [Validation(Required=false)]
        public string CatalogId { get; set; }

        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("ResourceUri")]
        [Validation(Required=false)]
        public List<ResourceUri> ResourceUri { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public int? UpdateTime { get; set; }

    }

}
