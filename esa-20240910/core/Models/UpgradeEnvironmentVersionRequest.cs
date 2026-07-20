// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpgradeEnvironmentVersionRequest : TeaModel {
        /// <summary>
        /// <para>The environment name. The version of this environment is upgraded and deployed to the environment with the next priority level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认环境</para>
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1245678****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
