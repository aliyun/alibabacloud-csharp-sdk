// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesRequest : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReservedInstanceId")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceId { get; set; }

        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<ModifyReservedInstancesRequestConfiguration> Configuration { get; set; }
        public class ModifyReservedInstancesRequestConfiguration : TeaModel {
            [NameInMap("ReservedInstanceName")]
            [Validation(Required=false)]
            public string ReservedInstanceName { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

        }

    }

}
