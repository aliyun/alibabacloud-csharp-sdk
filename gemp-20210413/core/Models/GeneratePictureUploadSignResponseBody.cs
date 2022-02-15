// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GeneratePictureUploadSignResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GeneratePictureUploadSignResponseBodyData Data { get; set; }
        public class GeneratePictureUploadSignResponseBodyData : TeaModel {
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<GeneratePictureUploadSignResponseBodyDataFiles> Files { get; set; }
            public class GeneratePictureUploadSignResponseBodyDataFiles : TeaModel {
                public string FileName { get; set; }
                public long? FileSize { get; set; }
                public string FileType { get; set; }
                public string Key { get; set; }
            }
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
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
