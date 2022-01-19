// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class ModifyAccountAuthorityRequest : TeaModel {
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public string AllowDatabases { get; set; }

        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public string AllowDictionaries { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public string TotalDatabases { get; set; }

        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public string TotalDictionaries { get; set; }

    }

}
