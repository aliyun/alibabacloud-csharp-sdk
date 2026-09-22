// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListZonesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID. Required. Specifies the region for which to query available zones. All returned zones are within this region.</para>
        /// <para>The value must be a region ID supported by WUYING Cloud Application. Call <a href="~~ListRegions~~">ListRegions</a> to obtain the supported region IDs. If an unsupported region is specified, the error code <c>InvalidParameter.ValueInvalid</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The operating system type. Required. Specifies the operating system used by the resource. This parameter, together with <c>ProductType</c>, determines the available zones. The value is case-insensitive. Use the following recommended values.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Windows</c>: Windows operating system.</description></item>
        /// <item><description><c>Linux</c>: Linux operating system.</description></item>
        /// <item><description><c>Android</c>: Android operating system.</description></item>
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
        /// <para>The product type. Required. Specifies the product for which to query available zones. The zone list is returned based on the available resources of this product in the specified region. The value is case-insensitive. Use the following recommended values.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>CloudApp</c>: WUYING Cloud Application.</description></item>
        /// <item><description><c>CloudBrowser</c>: Cloud Browser.</description></item>
        /// <item><description><c>WuyingServer</c>: Enterprise Edition Workstation.</description></item>
        /// <item><description><c>WuyingWorkstation</c>: Personal Edition Lingou Container Workstation.</description></item>
        /// <item><description><c>WuyingWorkstationTeam</c>: Lingou Team Edition Container Workstation.</description></item>
        /// <item><description><c>WuyingWorkstationBusiness</c>: Lingou Dedicated Edition Container Workstation.</description></item>
        /// <item><description><c>AndroidCloud</c>: Cloud Phone.</description></item>
        /// <item><description><c>AIAgent</c>: AgentBay (AI agent).</description></item>
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
