// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorAvailableConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The monitored nodes.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorAvailableConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// <para>The code of the city where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>Indicates whether the monitored node is selected for the health check by default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DefaultSelected")]
                [Validation(Required=false)]
                public bool? DefaultSelected { get; set; }

                /// <summary>
                /// <para>The name of the group to which the monitored node belongs.</para>
                /// <para>Valid values: Overseas Nodes, BGP Nodes, and ISP Nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Overseas Nodes</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The type of the group to which the monitored node belongs.</para>
                /// <para>Valid values: BGP, OVERSEAS, and ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OVERSEAS</para>
                /// </summary>
                [NameInMap("GroupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                /// <summary>
                /// <para>The code of the Internet service provider (ISP) to which the monitored node belongs.</para>
                /// <list type="bullet">
                /// <item><description>If the value of the GroupType parameter is BGP or OVERSEAS, the value of IspCode is 465 by default.</description></item>
                /// <item><description>If the value of the GroupType parameter is not BGP or OVERSEAS, valid values of IspCode are 232, 132, and 5. and is used together with CityCode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP to which the monitored node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// <para>Indicates whether the monitored node is deployed in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Mainland")]
                [Validation(Required=false)]
                public bool? Mainland { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
