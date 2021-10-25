// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetIfEcsTypeSupportHtConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DefaultHtEnabled")]
        [Validation(Required=false)]
        public bool? DefaultHtEnabled { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("SupportHtConfig")]
        [Validation(Required=false)]
        public bool? SupportHtConfig { get; set; }

    }

}
