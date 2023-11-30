// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DriveLogDetail : TeaModel {
        [NameInMap("force_delete")]
        [Validation(Required=false)]
        public bool? ForceDelete { get; set; }

        [NameInMap("handover_owner_name")]
        [Validation(Required=false)]
        public string HandoverOwnerName { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("owner_id")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("owner_name")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("owner_type")]
        [Validation(Required=false)]
        public string OwnerType { get; set; }

        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("update_to")]
        [Validation(Required=false)]
        public DriveLogDetailUpdateTo UpdateTo { get; set; }
        public class DriveLogDetailUpdateTo : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("owner_id")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("owner_name")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("owner_type")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("total_size")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

    }

}
