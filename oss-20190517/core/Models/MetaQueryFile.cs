// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class MetaQueryFile : TeaModel {
        [NameInMap("ETag")]
        [Validation(Required=false)]
        public string ETag { get; set; }

        [NameInMap("FileModifiedTime")]
        [Validation(Required=false)]
        public string FileModifiedTime { get; set; }

        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        [NameInMap("OSSCRC64")]
        [Validation(Required=false)]
        public string OSSCRC64 { get; set; }

        [NameInMap("OSSObjectType")]
        [Validation(Required=false)]
        public string OSSObjectType { get; set; }

        [NameInMap("OSSStorageClass")]
        [Validation(Required=false)]
        public string OSSStorageClass { get; set; }

        [NameInMap("OSSTagging")]
        [Validation(Required=false)]
        public MetaQueryFileOSSTagging OSSTagging { get; set; }
        public class MetaQueryFileOSSTagging : TeaModel {
            [NameInMap("Tagging")]
            [Validation(Required=false)]
            public List<MetaQueryTagging> Tagging { get; set; }

        }

        [NameInMap("OSSTaggingCount")]
        [Validation(Required=false)]
        public long? OSSTaggingCount { get; set; }

        [NameInMap("OSSUserMeta")]
        [Validation(Required=false)]
        public MetaQueryFileOSSUserMeta OSSUserMeta { get; set; }
        public class MetaQueryFileOSSUserMeta : TeaModel {
            [NameInMap("UserMeta")]
            [Validation(Required=false)]
            public List<MetaQueryUserMeta> UserMeta { get; set; }

        }

        [NameInMap("ObjectACL")]
        [Validation(Required=false)]
        public string ObjectACL { get; set; }

        [NameInMap("ServerSideEncryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        [NameInMap("ServerSideEncryptionCustomerAlgorithm")]
        [Validation(Required=false)]
        public string ServerSideEncryptionCustomerAlgorithm { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
