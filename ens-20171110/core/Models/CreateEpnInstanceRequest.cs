// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateEpnInstanceRequest : TeaModel {
        [NameInMap("EPNInstanceType")]
        [Validation(Required=true)]
        public string EPNInstanceType { get; set; }

        [NameInMap("EPNInstanceName")]
        [Validation(Required=false)]
        public string EPNInstanceName { get; set; }

        [NameInMap("InternetChargeType")]
        [Validation(Required=true)]
        public string InternetChargeType { get; set; }

        [NameInMap("NetworkingModel")]
        [Validation(Required=true)]
        public string NetworkingModel { get; set; }

        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=true)]
        public int? InternetMaxBandwidthOut { get; set; }

    }

}
