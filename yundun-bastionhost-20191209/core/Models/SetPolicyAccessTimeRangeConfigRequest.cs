// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyAccessTimeRangeConfigRequest : TeaModel {
        [NameInMap("AccessTimeRangeConfig")]
        [Validation(Required=false)]
        public SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfig AccessTimeRangeConfig { get; set; }
        public class SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfig : TeaModel {
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public List<SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfigEffectiveTime> EffectiveTime { get; set; }
            public class SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfigEffectiveTime : TeaModel {
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<int?> Days { get; set; }

                [NameInMap("Hours")]
                [Validation(Required=false)]
                public List<int?> Hours { get; set; }

            }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
