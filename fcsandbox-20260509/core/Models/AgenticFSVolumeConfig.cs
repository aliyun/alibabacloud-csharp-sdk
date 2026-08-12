// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class AgenticFSVolumeConfig : TeaModel {
        [NameInMap("groupID")]
        [Validation(Required=false)]
        public int? GroupID { get; set; }

        [NameInMap("serverAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public int? UserID { get; set; }

    }

}
