// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class StartupProbe : TeaModel {
        [NameInMap("FailureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        [NameInMap("InitialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        [NameInMap("PeriodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        [NameInMap("ProbeHandler")]
        [Validation(Required=false)]
        public ProbeHandler ProbeHandler { get; set; }

        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
