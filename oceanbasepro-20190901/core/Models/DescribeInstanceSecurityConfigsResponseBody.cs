// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceSecurityConfigsResponseBody : TeaModel {
        [NameInMap("InstanceSecurityConfigs")]
        [Validation(Required=false)]
        public DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs InstanceSecurityConfigs { get; set; }
        public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigs : TeaModel {
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public string CheckId { get; set; }

            [NameInMap("CheckTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
            public class DescribeInstanceSecurityConfigsResponseBodyInstanceSecurityConfigsSecurityConfigs : TeaModel {
                [NameInMap("ConfigDescription")]
                [Validation(Required=false)]
                public string ConfigDescription { get; set; }

                [NameInMap("ConfigGroup")]
                [Validation(Required=false)]
                public string ConfigGroup { get; set; }

                [NameInMap("ConfigName")]
                [Validation(Required=false)]
                public string ConfigName { get; set; }

                [NameInMap("Risk")]
                [Validation(Required=false)]
                public bool? Risk { get; set; }

                [NameInMap("RiskDescription")]
                [Validation(Required=false)]
                public string RiskDescription { get; set; }

            }

            [NameInMap("TotalCheckCount")]
            [Validation(Required=false)]
            public int? TotalCheckCount { get; set; }

            [NameInMap("TotalRiskCount")]
            [Validation(Required=false)]
            public int? TotalRiskCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
