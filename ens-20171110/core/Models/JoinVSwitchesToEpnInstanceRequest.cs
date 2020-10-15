// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class JoinVSwitchesToEpnInstanceRequest : TeaModel {
        [NameInMap("EPNInstanceId")]
        [Validation(Required=true)]
        public string EPNInstanceId { get; set; }

        [NameInMap("VSwitchesInfo")]
        [Validation(Required=true)]
        public string VSwitchesInfo { get; set; }

    }

}
