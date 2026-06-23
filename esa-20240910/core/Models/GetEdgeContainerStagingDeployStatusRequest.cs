// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerStagingDeployStatusRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: AppId is required. If AppId is not specified, the API returns InvalidParameter.appid (400). You can call ListEdgeContainerApps to obtain the application ID. 
        /// The AppId format is the prefix app- followed by 18 or more digits (at least 20 characters in total). You can obtain the actual value from the AppId field in the ListEdgeContainerApps response.
        /// Complete call chain example: CreateEdgeContainerApp → Call ListEdgeContainerApps to obtain AppId → GetEdgeContainerStagingDeployStatus</notice>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GetEdgeContainerStagingDeployStatus</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
