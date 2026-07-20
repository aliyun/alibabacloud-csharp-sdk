// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The environment name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认环境</para>
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// <para>The new environment name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>环境A</para>
        /// </summary>
        [NameInMap("NewName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        /// <summary>
        /// <para>Specifies whether the environment is read-only.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReadOnly")]
        [Validation(Required=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// <para>The Wireshark rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;duduko5.top&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33993121955****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The new site version number. Only the environment with the highest priority can be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
