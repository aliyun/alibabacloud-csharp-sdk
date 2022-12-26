// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientConfSetupRequest : TeaModel {
        [NameInMap("StrategyConfig")]
        [Validation(Required=false)]
        public string StrategyConfig { get; set; }

        [NameInMap("StrategyTag")]
        [Validation(Required=false)]
        public string StrategyTag { get; set; }

        [NameInMap("StrategyTagValue")]
        [Validation(Required=false)]
        public string StrategyTagValue { get; set; }

    }

}
