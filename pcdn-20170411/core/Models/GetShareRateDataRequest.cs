// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetShareRateDataRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("IspName")]
        [Validation(Required=false)]
        public string IspName { get; set; }

        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

    }

}
