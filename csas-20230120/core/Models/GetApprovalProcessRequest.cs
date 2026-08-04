// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalProcessRequest : TeaModel {
        /// <summary>
        /// <para>The approval flow ID. Value source:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListApprovalProcesses~~">ListApprovalProcesses</a>: queries the list of approval flows.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-fcc351b8a95b****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

    }

}
