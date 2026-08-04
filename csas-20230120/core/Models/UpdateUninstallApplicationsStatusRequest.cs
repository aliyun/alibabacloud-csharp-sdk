// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUninstallApplicationsStatusRequest : TeaModel {
        /// <summary>
        /// <para>List of uninstall request IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>Status of the uninstall request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Approved</b>: Approved.</para>
        /// </description></item>
        /// <item><description><para><b>Rejected</b>: Rejected.</para>
        /// </description></item>
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
