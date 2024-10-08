// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ContainerInfo : TeaModel {
        [NameInMap("CurrentReaon")]
        [Validation(Required=false)]
        public string CurrentReaon { get; set; }

        [NameInMap("CurrentStatus")]
        [Validation(Required=false)]
        public string CurrentStatus { get; set; }

        [NameInMap("CurrentTimestamp")]
        [Validation(Required=false)]
        public string CurrentTimestamp { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("LastReason")]
        [Validation(Required=false)]
        public string LastReason { get; set; }

        [NameInMap("LastStatus")]
        [Validation(Required=false)]
        public string LastStatus { get; set; }

        [NameInMap("LastTimestamp")]
        [Validation(Required=false)]
        public string LastTimestamp { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("Ready")]
        [Validation(Required=false)]
        public bool? Ready { get; set; }

        [NameInMap("RestartCount")]
        [Validation(Required=false)]
        public int? RestartCount { get; set; }

    }

}
