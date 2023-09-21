// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotProbeBindRequest : TeaModel {
        [NameInMap("BindId")]
        [Validation(Required=false)]
        public string BindId { get; set; }

        [NameInMap("BindPortList")]
        [Validation(Required=false)]
        public List<UpdateHoneypotProbeBindRequestBindPortList> BindPortList { get; set; }
        public class UpdateHoneypotProbeBindRequestBindPortList : TeaModel {
            [NameInMap("BindPort")]
            [Validation(Required=false)]
            public bool? BindPort { get; set; }

            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public int? EndPort { get; set; }

            [NameInMap("Fixed")]
            [Validation(Required=false)]
            public bool? Fixed { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Proto")]
            [Validation(Required=false)]
            public string Proto { get; set; }

            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public int? StartPort { get; set; }

            [NameInMap("TargetPort")]
            [Validation(Required=false)]
            public int? TargetPort { get; set; }

        }

        [NameInMap("BindType")]
        [Validation(Required=false)]
        public string BindType { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Ports")]
        [Validation(Required=false)]
        public string Ports { get; set; }

        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

        [NameInMap("ServiceIpList")]
        [Validation(Required=false)]
        public List<string> ServiceIpList { get; set; }

        [NameInMap("SetStatus")]
        [Validation(Required=false)]
        public int? SetStatus { get; set; }

    }

}
