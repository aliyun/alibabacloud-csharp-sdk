// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUninstallApplicationsStatusRequest : TeaModel {
        /// <summary>
        /// <para>The list of uninstall application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>The status of the uninstall application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Approved</b>: Approved.</description></item>
        /// <item><description><b>Rejected</b>: Rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Approved</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
