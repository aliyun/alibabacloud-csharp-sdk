// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetRiskStatisticsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("BeginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("ByDbId")]
        [Validation(Required=false)]
        public int? ByDbId { get; set; }

        [NameInMap("ByRiskLevel")]
        [Validation(Required=false)]
        public int? ByRiskLevel { get; set; }

        [NameInMap("ByRuleType")]
        [Validation(Required=false)]
        public int? ByRuleType { get; set; }

        [NameInMap("ByRuleId")]
        [Validation(Required=false)]
        public int? ByRuleId { get; set; }

    }

}
