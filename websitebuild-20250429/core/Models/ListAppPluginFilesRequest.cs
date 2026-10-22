// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppPluginFilesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway plugin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliplayer-react</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The version number. If you do not specify this parameter, the currently active version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.3</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

    }

}
