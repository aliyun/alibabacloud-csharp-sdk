// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcZoneResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ZoneList")]
        [Validation(Required=false)]
        public List<DescribeVpcZoneResponseBodyZoneList> ZoneList { get; set; }
        public class DescribeVpcZoneResponseBodyZoneList : TeaModel {
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("ZoneType")]
            [Validation(Required=false)]
            public string ZoneType { get; set; }

        }

    }

}
