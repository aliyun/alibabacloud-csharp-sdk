// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeWaitingOrdersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeWaitingOrdersResponseBodyData> Data { get; set; }
        public class DescribeWaitingOrdersResponseBodyData : TeaModel {
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("FailedMessage")]
            [Validation(Required=false)]
            public string FailedMessage { get; set; }

            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public long? InstanceAmount { get; set; }

            [NameInMap("InstanceInfos")]
            [Validation(Required=false)]
            public List<DescribeWaitingOrdersResponseBodyDataInstanceInfos> InstanceInfos { get; set; }
            public class DescribeWaitingOrdersResponseBodyDataInstanceInfos : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

            }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("LxCreateParam")]
            [Validation(Required=false)]
            public string LxCreateParam { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SuccessAmount")]
            [Validation(Required=false)]
            public long? SuccessAmount { get; set; }

            [NameInMap("WaitingOrderId")]
            [Validation(Required=false)]
            public string WaitingOrderId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
