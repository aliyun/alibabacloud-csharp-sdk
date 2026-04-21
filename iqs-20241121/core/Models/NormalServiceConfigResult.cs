// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class NormalServiceConfigResult : TeaModel {
        [NameInMap("availableTime")]
        [Validation(Required=false)]
        public string AvailableTime { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("userAPICountInfos")]
        [Validation(Required=false)]
        public List<UserAPICountInfo> UserAPICountInfos { get; set; }

    }

}
