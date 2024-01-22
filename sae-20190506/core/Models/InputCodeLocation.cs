// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class InputCodeLocation : TeaModel {
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
