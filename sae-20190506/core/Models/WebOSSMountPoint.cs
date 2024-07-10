// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebOSSMountPoint : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("BucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        [NameInMap("MountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
