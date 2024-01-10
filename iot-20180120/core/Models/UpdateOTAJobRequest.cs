// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class UpdateOTAJobRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("MaximumPerMinute")]
        [Validation(Required=false)]
        public int? MaximumPerMinute { get; set; }

        [NameInMap("SrcVersionList")]
        [Validation(Required=false)]
        public List<string> SrcVersionList { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateOTAJobRequestTags> Tags { get; set; }
        public class UpdateOTAJobRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("TargetSelection")]
        [Validation(Required=false)]
        public string TargetSelection { get; set; }

        [NameInMap("TimeoutInMinutes")]
        [Validation(Required=false)]
        public int? TimeoutInMinutes { get; set; }

        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
