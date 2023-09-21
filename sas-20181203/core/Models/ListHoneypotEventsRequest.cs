// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventsRequest : TeaModel {
        [NameInMap("AgentIdList")]
        [Validation(Required=false)]
        public List<string> AgentIdList { get; set; }

        [NameInMap("AlarmEventId")]
        [Validation(Required=false)]
        public long? AlarmEventId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        [NameInMap("HoneypotIdList")]
        [Validation(Required=false)]
        public List<string> HoneypotIdList { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PortraitId")]
        [Validation(Required=false)]
        public string PortraitId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RiskLevelList")]
        [Validation(Required=false)]
        public List<string> RiskLevelList { get; set; }

        [NameInMap("SrcIp")]
        [Validation(Required=false)]
        public string SrcIp { get; set; }

    }

}
