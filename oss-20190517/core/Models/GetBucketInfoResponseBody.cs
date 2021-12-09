// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketInfoResponseBody : TeaModel {
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public GetBucketInfoResponseBodyBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBodyBucketInfo : TeaModel {
            [NameInMap("AccessControlList")]
            [Validation(Required=false)]
            public GetBucketInfoResponseBodyBucketInfoAccessControlList AccessControlList { get; set; }
            public class GetBucketInfoResponseBodyBucketInfoAccessControlList : TeaModel {
                [NameInMap("Grant")]
                [Validation(Required=false)]
                public string Grant { get; set; }

            }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("CreationDate")]
            [Validation(Required=false)]
            public string CreationDate { get; set; }
            [NameInMap("CrossRegionReplication")]
            [Validation(Required=false)]
            public string CrossRegionReplication { get; set; }
            [NameInMap("ExtranetEndpoint")]
            [Validation(Required=false)]
            public string ExtranetEndpoint { get; set; }
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public Owner Owner { get; set; }
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }
            [NameInMap("TransferAcceleration")]
            [Validation(Required=false)]
            public string TransferAcceleration { get; set; }
        };

    }

}
