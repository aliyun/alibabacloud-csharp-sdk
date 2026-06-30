// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of areas.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAvailableAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAvailableAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// <para>The ID of the area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huabei</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The name of the area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China North</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The list of regions.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAvailableAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAvailableAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the region is in the Chinese mainland. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The region is in the Chinese mainland.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The region is not in the Chinese mainland.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ChinaMainland")]
                [Validation(Required=false)]
                public bool? ChinaMainland { get; set; }

                /// <summary>
                /// <para>The line type of the public IP address in the acceleration region.</para>
                /// <list type="bullet">
                /// <item><description><para><b>BGP</b> (default): BGP (Multi-ISP) line.</para>
                /// </description></item>
                /// <item><description><para><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("IspTypeList")]
                [Validation(Required=false)]
                public List<string> IspTypeList { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Qingdao)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>Indicates whether multi-zone deployment is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Multi-zone deployment is supported.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Multi-zone deployment is not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MultiAz")]
                [Validation(Required=false)]
                public bool? MultiAz { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: IPv6 is supported.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: IPv6 is not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportIpv6")]
                [Validation(Required=false)]
                public bool? SupportIpv6 { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A9B4E54C-9CCD-4002-91A9-D38C6C209192</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
