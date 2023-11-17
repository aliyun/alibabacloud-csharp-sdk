// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class SignInGroupRequest : TeaModel {
        [NameInMap("Additivity")]
        [Validation(Required=false)]
        public bool? Additivity { get; set; }

        [NameInMap("ChatDeviceId")]
        [Validation(Required=false)]
        public string ChatDeviceId { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SignedSkillGroupIdList")]
        [Validation(Required=false)]
        public string SignedSkillGroupIdList { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
