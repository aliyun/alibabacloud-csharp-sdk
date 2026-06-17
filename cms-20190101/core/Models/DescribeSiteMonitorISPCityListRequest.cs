// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorISPCityListRequest : TeaModel {
        /// <summary>
        /// <para>The name or ID of the city where the carrier detection point resides.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported for city names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Guiyang</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Specifies whether to query IPv4 probes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Queries IPv4 probes.</description></item>
        /// <item><description>false: Does not query IPv4 probes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IPV4")]
        [Validation(Required=false)]
        public bool? IPV4 { get; set; }

        /// <summary>
        /// <para>Specifies whether to query IPv6 probes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Queries IPv6 probes.</description></item>
        /// <item><description>false: Does not query IPv6 probes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IPV6")]
        [Validation(Required=false)]
        public bool? IPV6 { get; set; }

        /// <summary>
        /// <para>The name or ID of the carrier detection point.</para>
        /// <remarks>
        /// <para>Fuzzy match is supported for carrier names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>China Unicom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return all detection points. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): Returns all detection points.</description></item>
        /// <item><description>false: Returns only available detection points.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ViewAll")]
        [Validation(Required=false)]
        public bool? ViewAll { get; set; }

    }

}
