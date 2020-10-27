// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateElasticityAssuranceRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateElasticityAssuranceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateElasticityAssuranceRequestPrivatePoolOptions : TeaModel {
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

        [NameInMap("AssuranceTimes")]
        [Validation(Required=false)]
        public string AssuranceTimes { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=true)]
        public List<string> ZoneId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=true)]
        public List<string> InstanceType { get; set; }

        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("InstanceCpuCoreCount")]
        [Validation(Required=false)]
        public int? InstanceCpuCoreCount { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
