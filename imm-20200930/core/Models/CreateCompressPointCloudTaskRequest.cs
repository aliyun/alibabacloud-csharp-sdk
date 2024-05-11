// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateCompressPointCloudTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompressMethod")]
        [Validation(Required=false)]
        public string CompressMethod { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("KdtreeOption")]
        [Validation(Required=false)]
        public KdtreeOption KdtreeOption { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public Notification Notification { get; set; }

        [NameInMap("OctreeOption")]
        [Validation(Required=false)]
        public OctreeOption OctreeOption { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PointCloudFields")]
        [Validation(Required=false)]
        public List<string> PointCloudFields { get; set; }

        [NameInMap("PointCloudFileFormat")]
        [Validation(Required=false)]
        public string PointCloudFileFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
