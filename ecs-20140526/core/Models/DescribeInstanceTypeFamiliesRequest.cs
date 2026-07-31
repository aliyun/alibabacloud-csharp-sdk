// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceTypeFamiliesRequest : TeaModel {
        /// <summary>
        /// <para>The generation of instance families. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ecs-1: Series I instance family. These were among the first to go online and are cost-effective.</para>
        /// </description></item>
        /// <item><description><para>ecs-2: Series II instance family. This family features a second hardware and software upgrade with enhanced instance performance.</para>
        /// </description></item>
        /// <item><description><para>ecs-3: Series III instance family. This family delivers excellent performance and can handle various workload requirements.</para>
        /// </description></item>
        /// <item><description><para>ecs-4: Series IV instance family. This family includes common enterprise-level instance types (such as g5, c5, and r5), ECS Bare Metal instance types (such as ebmc5s, ebmg5s, and ebmr5s), and burstable instance types (such as t5). They provide strong scenario adaptability, can handle massive popular workloads, and deliver lower latency.</para>
        /// </description></item>
        /// <item><description><para>ecs-5: Series V instance family. This family includes common enterprise-level instance types (such as g6, c6, and r6), ECS Bare Metal instance types (such as ebmg6, ebmg6e, and ebmc6), and storage-enhanced instance family types (such as g6e). They deliver faster response times and superior performance.</para>
        /// </description></item>
        /// <item><description><para>ecs-6: Series VI instance family. This family includes enterprise-level instance types (such as hfc7, hfg7, and hfr7) and ECS Bare Metal instance types (such as ebmhfg7). This series of instance families is in invitational preview.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs-5</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
