// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

        [NameInMap("ElasticDailyPlanDay")]
        [Validation(Required=false)]
        public string ElasticDailyPlanDay { get; set; }

        [NameInMap("ElasticDailyPlanStatusList")]
        [Validation(Required=false)]
        public string ElasticDailyPlanStatusList { get; set; }

    }

}
