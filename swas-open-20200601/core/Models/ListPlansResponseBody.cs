// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListPlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The plan information.</para>
        /// </summary>
        [NameInMap("Plans")]
        [Validation(Required=false)]
        public List<ListPlansResponseBodyPlans> Plans { get; set; }
        public class ListPlansResponseBodyPlans : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth. Unit: Mbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
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
            /// <para>The number of credits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12500</para>
            /// </summary>
            [NameInMap("Credits")]
            [Validation(Required=false)]
            public int? Credits { get; set; }

            /// <summary>
            /// <para>The currency unit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CNY: Chinese Yuan.</para>
            /// </description></item>
            /// <item><description><para>USD: US Dollar.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>The currency unit is CNY on the China site and USD on the international site.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The disk capacity. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }

            /// <summary>
            /// <para>The disk type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ESSD: Enterprise SSD (ESSD) at performance level (PL) 0.</description></item>
            /// <item><description>SSD: standard SSD.</description></item>
            /// <item><description>CLOUD_EFFICIENCY: ultra cloud disk.</description></item>
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
            /// <para>The public network line type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BGP</b> (default): BGP line.</description></item>
            /// <item><description><b>BGP_NCO</b>: BGP (outside the Chinese mainland optimized) line.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public float? Memory { get; set; }

            /// <summary>
            /// <para>The monthly price of the simple application server plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public string OriginPrice { get; set; }

            /// <summary>
            /// <para>The plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swas.s2.c2m1s40b3t04</para>
            /// </summary>
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>The plan type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: general-purpose.</description></item>
            /// <item><description>CAPACITY: storage-optimized.</description></item>
            /// <item><description>PREVIOUS: previous generation.</description></item>
            /// <item><description>MULTI_IP: multiple public IP addresses.</description></item>
            /// <item><description>INTERNATIONAL: international.</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2861773.html">Instance families</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            /// <summary>
            /// <para>The number of public IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublicIpNum")]
            [Validation(Required=false)]
            public string PublicIpNum { get; set; }

            /// <summary>
            /// <para>The operating system type supported by the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;Linux&quot;,&quot;Windows&quot;]</para>
            /// </summary>
            [NameInMap("SupportPlatform")]
            [Validation(Required=false)]
            public string SupportPlatform { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListPlansResponseBodyPlansTags> Tags { get; set; }
            public class ListPlansResponseBodyPlansTags : TeaModel {
                /// <summary>
                /// <para>The Chinese title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("CnTitle")]
                [Validation(Required=false)]
                public string CnTitle { get; set; }

                /// <summary>
                /// <para>The color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>grey</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <para>The English title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BGP</para>
                /// </summary>
                [NameInMap("EnTitle")]
                [Validation(Required=false)]
                public string EnTitle { get; set; }

            }

            /// <summary>
            /// <para>The number of tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Tokens")]
            [Validation(Required=false)]
            public int? Tokens { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
