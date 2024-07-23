// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypeFamiliesRequest : TeaModel {
        /// <summary>
        /// <para>The generation of the instance family. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Overview of instance families</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ecs-1: Generation I, which consists of the earliest and cost-effective instance types</description></item>
        /// <item><description>ecs-2: Generation II, which provides upgraded software and hardware and higher performance than Generation I</description></item>
        /// <item><description>ecs-3: Generation III, which consists of high-performance instance families and is suitable for different business scenarios</description></item>
        /// <item><description>ecs-4: Generation IV, which consists of enterprise-level instance families (such as g5, c5, and r5), ECS Bare Metal Instance families (such as ebmc5s, ebmg5s, and ebmr5s), and burstable instance families (such as t5) and can meet a wide variety of business requirements with lower latency</description></item>
        /// <item><description>ecs-5: Generation V, which consists of enterprise-level instance families (such as g6, c6, and r6), ECS Bare Metal Instance families (such as ebmg6, ebmg6e, and ebmc6), and storage-enhanced instance families (such as g6e) and delivers quick response times and higher performance</description></item>
        /// <item><description>ecs-6: Generation VI, which consists of enterprise-level instance families (such as hfc7, hfg7, and hfr7) and ECS Bare Metal Instance families (such as ebmhfg7) and is in invitational preview</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-5</para>
        /// </summary>
        [NameInMap("Generation")]
        [Validation(Required=false)]
        public string Generation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:ECSforCloud@Alibaba.com">ECSforCloud@Alibaba.com</a></para>
        /// </summary>
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>155780923770</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance family. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECSforCloud</para>
        /// </summary>
        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>155780923770</para>
        /// </summary>
        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
