// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyResubmitConfigRequest : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ModifyResubmitConfigRequestRules> Rules { get; set; }
        public class ModifyResubmitConfigRequestRules : TeaModel {
            [NameInMap("ExceedMemoryException")]
            [Validation(Required=false)]
            public bool? ExceedMemoryException { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public string PeakMemory { get; set; }

            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

            [NameInMap("TargetGroupName")]
            [Validation(Required=false)]
            public string TargetGroupName { get; set; }

        }

    }

}
