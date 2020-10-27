// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCapacityReservationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=true)]
        public List<string> ZoneId { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateCapacityReservationRequestPrivatePoolOptions : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceAmount")]
        [Validation(Required=true)]
        public int? InstanceAmount { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=true)]
        public string InstanceType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
