// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotEventTrendRequest : TeaModel {
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public long? StartTimeStamp { get; set; }

    }

}
