// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class UpdateRingStatusRequest : TeaModel {
        [NameInMap("CallOutStatus")]
        [Validation(Required=false)]
        public string CallOutStatus { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UniqueBizId")]
        [Validation(Required=false)]
        public string UniqueBizId { get; set; }

    }

}
