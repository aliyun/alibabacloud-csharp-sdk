// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyPGHbaConfigRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("HbaItem")]
        [Validation(Required=false)]
        public List<ModifyPGHbaConfigRequestHbaItem> HbaItem { get; set; }
        public class ModifyPGHbaConfigRequestHbaItem : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("Option")]
            [Validation(Required=false)]
            public string Option { get; set; }

            [NameInMap("PriorityId")]
            [Validation(Required=false)]
            public int? PriorityId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
