// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GenerateProblemPictureUploadSignResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GenerateProblemPictureUploadSignResponseBodyData Data { get; set; }
        public class GenerateProblemPictureUploadSignResponseBodyData : TeaModel {
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
