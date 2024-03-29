// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ModifyFlowProjectClusterSettingRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DefaultQueue")]
        [Validation(Required=false)]
        public string DefaultQueue { get; set; }

        [NameInMap("DefaultUser")]
        [Validation(Required=false)]
        public string DefaultUser { get; set; }

        [NameInMap("HostList")]
        [Validation(Required=false)]
        public List<string> HostList { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("QueueList")]
        [Validation(Required=false)]
        public List<string> QueueList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("UserList")]
        [Validation(Required=false)]
        public List<string> UserList { get; set; }

    }

}
