// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class RollbackAppPluginVersionRequest : TeaModel {
        /// <summary>
        /// <para>The gateway plug-in ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1bae9ceaceea432d91c7069fab0dfc02</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The target version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("PluginVersion")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

    }

}
