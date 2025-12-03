// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class MetaCategory : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Depth")]
        [Validation(Required=false)]
        public int? Depth { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerIds")]
        [Validation(Required=false)]
        public List<long?> OwnerIds { get; set; }

        [NameInMap("OwnerNickNames")]
        [Validation(Required=false)]
        public List<string> OwnerNickNames { get; set; }

        [NameInMap("ParentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
