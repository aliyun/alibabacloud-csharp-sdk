// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalProcessRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the approval process. You can call the following operation to obtain the value:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListApprovalProcesses~~">ListApprovalProcesses</a>: Queries a list of approval processes in batches.</description></item>
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
