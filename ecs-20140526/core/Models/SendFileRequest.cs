// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class SendFileRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long Timeout { get; set; }

        [NameInMap("TargetDir")]
        [Validation(Required=true)]
        public string TargetDir { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public List<string> InstanceId { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=true)]
        public string Content { get; set; }

        [NameInMap("FileOwner")]
        [Validation(Required=false)]
        public string FileOwner { get; set; }

        [NameInMap("FileGroup")]
        [Validation(Required=false)]
        public string FileGroup { get; set; }

        [NameInMap("FileMode")]
        [Validation(Required=false)]
        public string FileMode { get; set; }

        [NameInMap("Overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

    }

}
