// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadOSSFileJobRequest : TeaModel {
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("FileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UploadTarget")]
        [Validation(Required=false)]
        public CreateUploadOSSFileJobRequestUploadTarget UploadTarget { get; set; }
        public class CreateUploadOSSFileJobRequestUploadTarget : TeaModel {
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

        }

    }

}
