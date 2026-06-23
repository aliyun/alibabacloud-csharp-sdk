// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class RebuildEdgeContainerAppStagingEnvRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required. If this parameter is not specified, the API returns InvalidParameter.appid (400). You can call ListEdgeContainerApps to obtain a valid application ID.
        /// Dependency chain: CreateEdgeContainerApp (if not created) → CreateEdgeContainerAppVersion → PublishEdgeContainerAppVersion (environment=staging) → RebuildEdgeContainerAppStagingEnv
        /// </notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
