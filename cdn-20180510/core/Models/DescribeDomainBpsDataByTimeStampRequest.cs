// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("IspNames")]
        [Validation(Required=false)]
        public string IspNames { get; set; }

        [NameInMap("LocationNames")]
        [Validation(Required=false)]
        public string LocationNames { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public string TimePoint { get; set; }

    }

}
