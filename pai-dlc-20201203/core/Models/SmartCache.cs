// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SmartCache : TeaModel {
        [NameInMap("CacheWorkerNum")]
        [Validation(Required=false)]
        public long? CacheWorkerNum { get; set; }

        [NameInMap("CacheWorkerSize")]
        [Validation(Required=false)]
        public long? CacheWorkerSize { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("SmartCacheId")]
        [Validation(Required=false)]
        public string SmartCacheId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
