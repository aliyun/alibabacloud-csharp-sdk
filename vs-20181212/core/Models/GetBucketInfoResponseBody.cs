// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class GetBucketInfoResponseBody : TeaModel {
        [NameInMap("BucketInfo")]
        [Validation(Required=false)]
        public GetBucketInfoResponseBodyBucketInfo BucketInfo { get; set; }
        public class GetBucketInfoResponseBodyBucketInfo : TeaModel {
            [NameInMap("BucketAcl")]
            [Validation(Required=false)]
            public string BucketAcl { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("DataRedundancyType")]
            [Validation(Required=false)]
            public string DataRedundancyType { get; set; }
            [NameInMap("DispatcherType")]
            [Validation(Required=false)]
            public string DispatcherType { get; set; }
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
