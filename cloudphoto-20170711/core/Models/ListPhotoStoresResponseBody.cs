// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListPhotoStoresResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhotoStores")]
        [Validation(Required=false)]
        public List<ListPhotoStoresResponseBodyPhotoStores> PhotoStores { get; set; }
        public class ListPhotoStoresResponseBodyPhotoStores : TeaModel {
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

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public List<ListPhotoStoresResponseBodyPhotoStoresBuckets> Buckets { get; set; }
            public class ListPhotoStoresResponseBodyPhotoStoresBuckets : TeaModel {
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
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

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
