// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CallOnlinePrivacyNumberRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TelA")]
        [Validation(Required=false)]
        public string TelA { get; set; }

        [NameInMap("TelB")]
        [Validation(Required=false)]
        public string TelB { get; set; }

    }

}
