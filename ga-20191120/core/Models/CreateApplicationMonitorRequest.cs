// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateApplicationMonitorRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DetectThreshold")]
        [Validation(Required=false)]
        public int? DetectThreshold { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
