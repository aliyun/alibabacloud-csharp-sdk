// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListRegionIdRequest : TeaModel {
        /// <summary>
        /// <para>The product type for querying available image regions. If this parameter is omitted, the query defaults to CloudApp. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudGame</b>: cloud gaming</description></item>
        /// <item><description><b>CloudApp</b>: WUYING Cloud Application</description></item>
        /// <item><description><b>CloudBrowser</b>: secure browser</description></item>
        /// <item><description><b>CloudDesktop</b>: WUYING Cloud Desktop</description></item>
        /// <item><description><b>ImageBuilder</b>: image creation resources</description></item>
        /// <item><description><b>ImageValidate</b>: image validation resources</description></item>
        /// <item><description><b>AndroidCloud</b>: Android cloud</description></item>
        /// <item><description><b>GpuRender</b>: GPU rendering</description></item>
        /// <item><description><b>AndroidGpuRender</b>: Android cloud GPU rendering</description></item>
        /// <item><description><b>WuyingServer</b>: enterprise edition workstation</description></item>
        /// <item><description><b>GpuProxy</b>: GPU remote rendering proxy</description></item>
        /// <item><description><b>GpuCache</b>: GPU remote rendering cache</description></item>
        /// <item><description><b>AIAgent</b>: AI agent service</description></item>
        /// <item><description><b>HostedDesktop</b>: hosted desktop</description></item>
        /// <item><description><b>WuyingWorkstation</b>: personal edition container workstation</description></item>
        /// <item><description><b>WuyingWorkstationBusiness</b>: business edition container workstation</description></item>
        /// <item><description><b>WuyingWorkstationTeam</b>: Linggou container workstation team edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
