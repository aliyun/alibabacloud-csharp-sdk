// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCompressPointCloudTaskRequest : TeaModel {
        [NameInMap("CompressMethod")]
        [Validation(Required=false)]
        public string CompressMethod { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("KdtreeOption")]
        [Validation(Required=false)]
        public KdtreeOption KdtreeOption { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("OctreeOption")]
        [Validation(Required=false)]
        public OctreeOption OctreeOption { get; set; }

        [NameInMap("PointCloudFields")]
        [Validation(Required=false)]
        public List<string> PointCloudFields { get; set; }

        [NameInMap("PointCloudFileFormat")]
        [Validation(Required=false)]
        public string PointCloudFileFormat { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
