// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetWorkspaceResponseBody : TeaModel {
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("JobLifecycle")]
        [Validation(Required=false)]
        public int? JobLifecycle { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string Storage { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
