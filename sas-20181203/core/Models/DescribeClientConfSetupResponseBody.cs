// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfSetupResponseBody : TeaModel {
        [NameInMap("ClientConf")]
        [Validation(Required=false)]
        public DescribeClientConfSetupResponseBodyClientConf ClientConf { get; set; }
        public class DescribeClientConfSetupResponseBodyClientConf : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("StrategyTag")]
            [Validation(Required=false)]
            public string StrategyTag { get; set; }

            [NameInMap("StrategyTagValue")]
            [Validation(Required=false)]
            public string StrategyTagValue { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
