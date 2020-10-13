// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetBandwidthDataRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Region")]
        [Validation(Required=true)]
        public string Region { get; set; }

        [NameInMap("IspName")]
        [Validation(Required=true)]
        public string IspName { get; set; }

        [NameInMap("PlatformType")]
        [Validation(Required=true)]
        public string PlatformType { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=true)]
        public string BusinessType { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=true)]
        public string StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=true)]
        public string EndDate { get; set; }

    }

}
