// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GeneratePictureUploadSignRequest : TeaModel {
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GeneratePictureUploadSignRequestFiles> Files { get; set; }
        public class GeneratePictureUploadSignRequestFiles : TeaModel {
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
