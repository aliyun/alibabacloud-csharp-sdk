// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAIQueryResultRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The AI analysis ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16896fa8-37f6-4c70-bb32-67fa9817d426</para>
        /// </summary>
        [NameInMap("analysisId")]
        [Validation(Required=false)]
        public string AnalysisId { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
