// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateBuildpackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BuildpackId")]
        [Validation(Required=false)]
        public string BuildpackId { get; set; }

        [NameInMap("UploadEndpoints")]
        [Validation(Required=false)]
        public List<CreateBuildpackResponseBodyUploadEndpoints> UploadEndpoints { get; set; }
        public class CreateBuildpackResponseBodyUploadEndpoints : TeaModel {
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("EncodedPolicy")]
            [Validation(Required=false)]
            public string EncodedPolicy { get; set; }

            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
