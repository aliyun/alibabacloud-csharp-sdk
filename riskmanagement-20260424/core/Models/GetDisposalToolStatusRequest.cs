// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetDisposalToolStatusRequest : TeaModel {
        /// <summary>
        /// <para>The authorization type.</para>
        /// <list type="bullet">
        /// <item><description><b>DisposalTool</b>: one-click disposal authorization type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DisposalTool</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

    }

}
