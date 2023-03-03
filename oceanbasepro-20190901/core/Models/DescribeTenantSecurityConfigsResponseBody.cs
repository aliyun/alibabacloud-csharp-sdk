// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantSecurityConfigsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public DescribeTenantSecurityConfigsResponseBodyConfigs Configs { get; set; }
        public class DescribeTenantSecurityConfigsResponseBodyConfigs : TeaModel {
            [NameInMap("TenantSecurityConfigs")]
            [Validation(Required=false)]
            public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs> TenantSecurityConfigs { get; set; }
            public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigs : TeaModel {
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public int? RiskCount { get; set; }

                [NameInMap("SecurityConfigs")]
                [Validation(Required=false)]
                public List<DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs> SecurityConfigs { get; set; }
                public class DescribeTenantSecurityConfigsResponseBodyConfigsTenantSecurityConfigsSecurityConfigs : TeaModel {
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

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

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
