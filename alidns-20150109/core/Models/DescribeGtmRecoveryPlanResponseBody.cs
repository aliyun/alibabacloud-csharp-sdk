// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmRecoveryPlanResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("LastRollbackTime")]
        [Validation(Required=false)]
        public string LastRollbackTime { get; set; }

        [NameInMap("FaultAddrPoolNum")]
        [Validation(Required=false)]
        public int? FaultAddrPoolNum { get; set; }

        [NameInMap("FaultAddrPools")]
        [Validation(Required=false)]
        public DescribeGtmRecoveryPlanResponseBodyFaultAddrPools FaultAddrPools { get; set; }
        public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPools : TeaModel {
            [NameInMap("FaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool> FaultAddrPool { get; set; }
            public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPool : TeaModel {
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public List<DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddr> Addr { get; set; }
                public class DescribeGtmRecoveryPlanResponseBodyFaultAddrPoolsFaultAddrPoolAddr : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

            }
        };

        [NameInMap("LastExecuteTime")]
        [Validation(Required=false)]
        public string LastExecuteTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("LastExecuteTimestamp")]
        [Validation(Required=false)]
        public long? LastExecuteTimestamp { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        [NameInMap("LastRollbackTimestamp")]
        [Validation(Required=false)]
        public long? LastRollbackTimestamp { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

    }

}
