// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20170601.Models
{
    public class DescribeHiTSDBInstanceListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeHiTSDBInstanceListResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeHiTSDBInstanceListResponseBodyInstanceList : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("MaxSeriesPerDatabase")]
            [Validation(Required=false)]
            public string MaxSeriesPerDatabase { get; set; }

            [NameInMap("PaymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("InstanceStorage")]
            [Validation(Required=false)]
            public string InstanceStorage { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            [NameInMap("InstanceAlias")]
            [Validation(Required=false)]
            public string InstanceAlias { get; set; }

            [NameInMap("InstanceTps")]
            [Validation(Required=false)]
            public string InstanceTps { get; set; }

            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("GmtExpire")]
            [Validation(Required=false)]
            public string GmtExpire { get; set; }

        }

    }

}
