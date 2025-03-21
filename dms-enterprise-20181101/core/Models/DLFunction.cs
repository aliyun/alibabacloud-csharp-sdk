// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class DLFunction : TeaModel {
        [NameInMap("CatalogName")]
        [Validation(Required=false)]
        public string CatalogName { get; set; }

        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public int? CreateTime { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public long? CreatorId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        [NameInMap("ModifierId")]
        [Validation(Required=false)]
        public long? ModifierId { get; set; }

        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("OwnerType")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("ResourceUris")]
        [Validation(Required=false)]
        public List<DLResourceUri> ResourceUris { get; set; }

    }

}
