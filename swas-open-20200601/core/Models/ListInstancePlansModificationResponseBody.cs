// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListInstancePlansModificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The operating system types supported by the plan.</para>
        /// </summary>
        [NameInMap("Plans")]
        [Validation(Required=false)]
        public List<ListInstancePlansModificationResponseBodyPlans> Plans { get; set; }
        public class ListInstancePlansModificationResponseBodyPlans : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The number of vCPUs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Core")]
            [Validation(Required=false)]
            public int? Core { get; set; }

            /// <summary>
            /// <para>The unit of the plan price. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CNY</description></item>
            /// <item><description>USD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The disk size of the simple application server. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// <para>The category of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SSD: standard SSD</description></item>
            /// <item><description>ESSD: enhanced SSD</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ESSD</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The monthly data transfer quota. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public int? Flow { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public int? Memory { get; set; }

            /// <summary>
            /// <para>The price of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public double? OriginPrice { get; set; }

            /// <summary>
            /// <para>The ID of the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swas.s2.c2m1s40b3t04</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The operating system types supported by the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Linux&quot;,&quot;Windows&quot;]</para>
            /// </summary>
            [NameInMap("SupportPlatform")]
            [Validation(Required=false)]
            public string SupportPlatform { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
