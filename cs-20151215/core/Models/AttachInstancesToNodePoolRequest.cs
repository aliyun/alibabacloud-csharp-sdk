// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesToNodePoolRequest : TeaModel {
        [NameInMap("format_disk")]
        [Validation(Required=false)]
        public bool? FormatDisk { get; set; }

        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        [NameInMap("keep_instance_name")]
        [Validation(Required=false)]
        public bool? KeepInstanceName { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
