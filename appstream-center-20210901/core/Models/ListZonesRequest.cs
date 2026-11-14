// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListZonesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. Required. Specifies the region for which you want to query available zones. All returned zones are located in this region.</para>
        /// <para>The value must be a region ID supported by App Streaming. You can call <a href="~~ListRegions~~">ListRegions</a> to query the supported region IDs. If you specify an unsupported region, the error code InvalidParameter.ValueInvalid is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The operating system type. Required. Specifies the operating system used by the resource. This parameter and ProductType together determine the available zones. The value is case-insensitive. Use one of the following values:</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows operating system</description></item>
        /// <item><description>Linux: Linux operating system</description></item>
        /// <item><description>Android: Android operating system</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The product type. Required. Specifies the product for which you want to query available zones. The list of available zones is returned based on the available resources of the product in the specified region. The value is case-insensitive. Use one of the following values:</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudApp: App Streaming</description></item>
        /// <item><description>CloudBrowser: Cloud Browser</description></item>
        /// <item><description>WuyingServer: Enterprise Edition workstation</description></item>
        /// <item><description>WuyingWorkstation: Personal Edition Linggou container workstation</description></item>
        /// <item><description>WuyingWorkstationTeam: Team Edition Linggou container workstation</description></item>
        /// <item><description>WuyingWorkstationBusiness: Dedicated Edition Linggou container workstation</description></item>
        /// <item><description>AndroidCloud: Cloud Phone</description></item>
        /// <item><description>AIAgent: AgentBay (AI agent)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
