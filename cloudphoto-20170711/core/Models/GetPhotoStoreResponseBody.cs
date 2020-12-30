// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetPhotoStoreResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhotoStore")]
        [Validation(Required=false)]
        public GetPhotoStoreResponseBodyPhotoStore PhotoStore { get; set; }
        public class GetPhotoStoreResponseBodyPhotoStore : TeaModel {
            [NameInMap("AutoCleanDays")]
            [Validation(Required=false)]
            public int? AutoCleanDays { get; set; }
            [NameInMap("IdStr")]
            [Validation(Required=false)]
            public string IdStr { get; set; }
            [NameInMap("Mtime")]
            [Validation(Required=false)]
            public long? Mtime { get; set; }
            [NameInMap("Ctime")]
            [Validation(Required=false)]
            public long? Ctime { get; set; }
            [NameInMap("DefaultTrashQuota")]
            [Validation(Required=false)]
            public long? DefaultTrashQuota { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public List<GetPhotoStoreResponseBodyPhotoStoreBuckets> Buckets { get; set; }
            public class GetPhotoStoreResponseBodyPhotoStoreBuckets : TeaModel {
                public string Acl { get; set; }
                public string State { get; set; }
                public string Region { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("DefaultQuota")]
            [Validation(Required=false)]
            public long? DefaultQuota { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("AutoCleanEnabled")]
            [Validation(Required=false)]
            public bool? AutoCleanEnabled { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
