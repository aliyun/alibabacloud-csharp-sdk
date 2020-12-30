// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Uis20180821.Models
{
    public class DescribeUisesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Uises")]
        [Validation(Required=false)]
        public DescribeUisesResponseBodyUises Uises { get; set; }
        public class DescribeUisesResponseBodyUises : TeaModel {
            [NameInMap("Uis")]
            [Validation(Required=false)]
            public List<DescribeUisesResponseBodyUisesUis> Uis { get; set; }
            public class DescribeUisesResponseBodyUisesUis : TeaModel {
                public string Status { get; set; }
                public string UisId { get; set; }
                public string ConnectionType { get; set; }
                public string BandwidthType { get; set; }
                public long? CreateTime { get; set; }
                public string ChargeType { get; set; }
                public string PayType { get; set; }
                public DescribeUisesResponseBodyUisesUisUserInfo UserInfo { get; set; }
                public class DescribeUisesResponseBodyUisesUisUserInfo : TeaModel {
                    [NameInMap("ClientInfoDBAccount")]
                    [Validation(Required=false)]
                    public string ClientInfoDBAccount { get; set; }

                    [NameInMap("ClientInfoDB")]
                    [Validation(Required=false)]
                    public string ClientInfoDB { get; set; }

                    [NameInMap("ClientInfoDBPassword")]
                    [Validation(Required=false)]
                    public string ClientInfoDBPassword { get; set; }

                }
                public string SslClientCertUrl { get; set; }
                public int? ConnectionCount { get; set; }
                public DescribeUisesResponseBodyUisesUisUisNodeIds UisNodeIds { get; set; }
                public class DescribeUisesResponseBodyUisesUisUisNodeIds : TeaModel {
                    [NameInMap("UisNodeIds")]
                    [Validation(Required=false)]
                    public List<string> UisNodeIds { get; set; }

                }
                public long? EndTime { get; set; }
                public int? Bandwidth { get; set; }
                public string Description { get; set; }
                public string ServiceRegion { get; set; }
                public int? ConnectionBandwidth { get; set; }
                public string BusinessStatus { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
