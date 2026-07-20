// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerDeployRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.&gt;Notice: This parameter is required. If this parameter is not specified, the service returns InvalidParameter.appid (400). You can call ListEdgeContainerApps to obtain a valid AppId. If you have not activated the Edge Container service, activate it first, and then call CreateEdgeContainerApp to create an application and obtain the AppId.
        /// </notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>GetEdgeContainerDeployRegions</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
