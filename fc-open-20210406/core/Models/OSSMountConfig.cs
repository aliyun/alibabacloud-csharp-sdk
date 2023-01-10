// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class OSSMountConfig : TeaModel {
        [NameInMap("mountPoints")]
        [Validation(Required=false)]
        public List<OSSMountConfigMountPoints> MountPoints { get; set; }
        public class OSSMountConfigMountPoints : TeaModel {
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

}
