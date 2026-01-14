// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAvailableAccelerateAreasResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about acceleration areas.</para>
        /// </summary>
        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<ListAvailableAccelerateAreasResponseBodyAreas> Areas { get; set; }
        public class ListAvailableAccelerateAreasResponseBodyAreas : TeaModel {
            /// <summary>
            /// <para>The ID of the acceleration area.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huabei</para>
            /// </summary>
            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            /// <summary>
            /// <para>The acceleration area name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>North China</para>
            /// </summary>
            [NameInMap("LocalName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            /// <summary>
            /// <para>The information about acceleration regions.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<ListAvailableAccelerateAreasResponseBodyAreasRegionList> RegionList { get; set; }
            public class ListAvailableAccelerateAreasResponseBodyAreasRegionList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the region is in the Chinese mainland. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ChinaMainland")]
                [Validation(Required=false)]
                public bool? ChinaMainland { get; set; }

                /// <summary>
                /// <para>The line type of the elastic IP address (EIP) in the acceleration region. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>BGP</b>: BGP (Multi-ISP) lines.</description></item>
                /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("IspTypeList")]
                [Validation(Required=false)]
                public List<string> IspTypeList { get; set; }

                /// <summary>
                /// <para>The acceleration region name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Qingdao)</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>Indicates whether multiple zones are supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MultiAz")]
                [Validation(Required=false)]
                public bool? MultiAz { get; set; }

                /// <summary>
                /// <para>The ID of the acceleration region.</para>
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
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A9B4E54C-9CCD-4002-91A9-D38C6C209192</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
