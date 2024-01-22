// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class OSSMountPoint : TeaModel {
        [NameInMap("bucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("bucketPath")]
        [Validation(Required=false)]
        public string BucketPath { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("mountDir")]
        [Validation(Required=false)]
        public string MountDir { get; set; }

        [NameInMap("readOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

    }

}
