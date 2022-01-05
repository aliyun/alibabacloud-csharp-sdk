// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyElasticPlanRequest : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("ElasticPlanEnable")]
        [Validation(Required=false)]
        public bool? ElasticPlanEnable { get; set; }

        [NameInMap("ElasticPlanEndDay")]
        [Validation(Required=false)]
        public string ElasticPlanEndDay { get; set; }

        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        [NameInMap("ElasticPlanNodeNum")]
        [Validation(Required=false)]
        public int? ElasticPlanNodeNum { get; set; }

        [NameInMap("ElasticPlanStartDay")]
        [Validation(Required=false)]
        public string ElasticPlanStartDay { get; set; }

        [NameInMap("ElasticPlanTimeEnd")]
        [Validation(Required=false)]
        public string ElasticPlanTimeEnd { get; set; }

        [NameInMap("ElasticPlanTimeStart")]
        [Validation(Required=false)]
        public string ElasticPlanTimeStart { get; set; }

        [NameInMap("ElasticPlanWeeklyRepeat")]
        [Validation(Required=false)]
        public string ElasticPlanWeeklyRepeat { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

    }

}
