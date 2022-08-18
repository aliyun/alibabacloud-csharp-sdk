// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CustomContainerConfigInfo : TeaModel {
        [NameInMap("accelerationInfo")]
        [Validation(Required=false)]
        public AccelerationInfo AccelerationInfo { get; set; }

        [NameInMap("accelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        [NameInMap("args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

    }

}
