// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypeFamiliesRequest : TeaModel {
        /// <summary>
        /// The generation of the instance family. For more information, see [Instance families](~~25378~~). Valid values:
        /// 
        /// *   ecs-1: Generation I, which consists of the earliest and cost-effective instance types
        /// *   ecs-2: Generation II, which provides upgraded software and hardware and higher performance than Generation I
        /// *   ecs-3: Generation III, which consists of high-performance instance families and is suitable for different business scenarios
        /// *   ecs-4: Generation IV, which consists of enterprise-level instance families (such as g5, c5, and r5), Bare Metal Instance families (such as ebmc5s, ebmg5s, and ebmr5s), and burstable instance families (such as t5) that can meet a wide variety of business requirements with lower latency
        /// *   ecs-5: Generation V, which consists of enterprise-level instance families (such as g6, c6, and r6), Bare Metal Instance families (such as ebmg6, ebmg6e, and ebmc6), and storage enhanced instance families (such as g6e) and delivers quick response and higher performance
        /// *   ecs-6: Generation VI, which consists of enterprise-level instance families (such as hfc7, hfg7, and hfr7) and Bare Metal Instance families (such as ebmhfg7) and is in invitational preview
        /// </summary>
        [NameInMap("Generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
