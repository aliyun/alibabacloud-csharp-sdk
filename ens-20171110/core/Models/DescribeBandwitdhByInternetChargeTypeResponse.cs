// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandwitdhByInternetChargeTypeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=true)]
        public string InternetChargeType { get; set; }

        [NameInMap("BandwidthValue")]
        [Validation(Required=true)]
        public long BandwidthValue { get; set; }

        [NameInMap("TimeStamp")]
        [Validation(Required=true)]
        public string TimeStamp { get; set; }

    }

}
