// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDBNodeDirectVipInfoResponseBody : TeaModel {
        [NameInMap("DirectVipInfo")]
        [Validation(Required=false)]
        public DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo DirectVipInfo { get; set; }
        public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfo : TeaModel {
            [NameInMap("VipInfo")]
            [Validation(Required=false)]
            public List<DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo> VipInfo { get; set; }
            public class DescribeDBNodeDirectVipInfoResponseBodyDirectVipInfoVipInfo : TeaModel {
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Vip")]
                [Validation(Required=false)]
                public string Vip { get; set; }

            }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
