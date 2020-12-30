// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ModifyJobGroupRequest : TeaModel {
        [NameInMap("JobGroupName")]
        [Validation(Required=false)]
        public string JobGroupName { get; set; }

        [NameInMap("ResourceProfileId")]
        [Validation(Required=false)]
        public string ResourceProfileId { get; set; }

        [NameInMap("AlgoLibId")]
        [Validation(Required=false)]
        public string AlgoLibId { get; set; }

        [NameInMap("PlanedJobCount")]
        [Validation(Required=false)]
        public int? PlanedJobCount { get; set; }

        [NameInMap("StreamPerJob")]
        [Validation(Required=false)]
        public int? StreamPerJob { get; set; }

        [NameInMap("JobCount")]
        [Validation(Required=false)]
        public int? JobCount { get; set; }

        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("JobGroupParams")]
        [Validation(Required=false)]
        public List<ModifyJobGroupRequestJobGroupParams> JobGroupParams { get; set; }
        public class ModifyJobGroupRequestJobGroupParams : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
