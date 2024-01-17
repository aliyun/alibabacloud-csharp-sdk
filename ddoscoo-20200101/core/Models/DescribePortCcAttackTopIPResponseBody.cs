// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortCcAttackTopIPResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TopIp")]
        [Validation(Required=false)]
        public List<DescribePortCcAttackTopIPResponseBodyTopIp> TopIp { get; set; }
        public class DescribePortCcAttackTopIPResponseBodyTopIp : TeaModel {
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

        }

    }

}
