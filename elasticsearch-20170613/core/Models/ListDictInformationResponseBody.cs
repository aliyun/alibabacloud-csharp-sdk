// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDictInformationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDictInformationResponseBodyResult Result { get; set; }
        public class ListDictInformationResponseBodyResult : TeaModel {
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }
            [NameInMap("ossObject")]
            [Validation(Required=false)]
            public ListDictInformationResponseBodyResultOssObject OssObject { get; set; }
            public class ListDictInformationResponseBodyResultOssObject : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("etag")]
                [Validation(Required=false)]
                public string Etag { get; set; }

            }
        };

    }

}
