// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeInstancePasswordsSettingResponseBody : TeaModel {
        [NameInMap("InstancePasswordSetting")]
        [Validation(Required=false)]
        public bool? InstancePasswordSetting { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VncPasswordSetting")]
        [Validation(Required=false)]
        public bool? VncPasswordSetting { get; set; }

    }

}
