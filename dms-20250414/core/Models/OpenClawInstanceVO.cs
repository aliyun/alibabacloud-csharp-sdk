// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OpenClawInstanceVO : TeaModel {
        [NameInMap("AliyunAccountUid")]
        [Validation(Required=false)]
        public string AliyunAccountUid { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("BasicAuthPassword")]
        [Validation(Required=false)]
        public string BasicAuthPassword { get; set; }

        [NameInMap("BasicAuthUsername")]
        [Validation(Required=false)]
        public string BasicAuthUsername { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public double? Cpu { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("ImageInfo")]
        [Validation(Required=false)]
        public OpenClawInstanceVOImageInfo ImageInfo { get; set; }
        public class OpenClawInstanceVOImageInfo : TeaModel {
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public long? ImageId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            [NameInMap("VersionDesc")]
            [Validation(Required=false)]
            public string VersionDesc { get; set; }

        }

        [NameInMap("InstanceDesc")]
        [Validation(Required=false)]
        public string InstanceDesc { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceRegion")]
        [Validation(Required=false)]
        public string InstanceRegion { get; set; }

        [NameInMap("LastActiveTime")]
        [Validation(Required=false)]
        public string LastActiveTime { get; set; }

        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        [NameInMap("OpenclawToken")]
        [Validation(Required=false)]
        public string OpenclawToken { get; set; }

        [NameInMap("OwnerUid")]
        [Validation(Required=false)]
        public string OwnerUid { get; set; }

        [NameInMap("PublicDomain")]
        [Validation(Required=false)]
        public string PublicDomain { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("StatusDesc")]
        [Validation(Required=false)]
        public string StatusDesc { get; set; }

        [NameInMap("StatusMessage")]
        [Validation(Required=false)]
        public string StatusMessage { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
