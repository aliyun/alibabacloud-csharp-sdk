// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InputCodeLocation : TeaModel {
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        [NameInMap("zipFile")]
        [Validation(Required=false)]
        public string ZipFile { get; set; }

    }

}
