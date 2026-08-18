// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetServiceLinkedRoleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SecuritySense</b>: security check authorization</description></item>
        /// <item><description><b>DisposalTool</b>: threat removal tool authorization</description></item>
        /// <item><description><b>SensePosture</b>: security posture authorization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DisposalTool</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

    }

}
