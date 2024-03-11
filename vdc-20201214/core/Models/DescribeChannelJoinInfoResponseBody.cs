// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelJoinInfoResponseBody : TeaModel {
        [NameInMap("JoinFastSuccessRate")]
        [Validation(Required=false)]
        public string JoinFastSuccessRate { get; set; }

        [NameInMap("JoinSlowThreshold")]
        [Validation(Required=false)]
        public long? JoinSlowThreshold { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
