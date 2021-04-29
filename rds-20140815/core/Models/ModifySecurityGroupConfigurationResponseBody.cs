// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifySecurityGroupConfigurationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public ModifySecurityGroupConfigurationResponseBodyItems Items { get; set; }
        public class ModifySecurityGroupConfigurationResponseBodyItems : TeaModel {
            [NameInMap("EcsSecurityGroupRelation")]
            [Validation(Required=false)]
            public List<ModifySecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation> EcsSecurityGroupRelation { get; set; }
            public class ModifySecurityGroupConfigurationResponseBodyItemsEcsSecurityGroupRelation : TeaModel {
                public string SecurityGroupId { get; set; }
                public string NetworkType { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

    }

}
