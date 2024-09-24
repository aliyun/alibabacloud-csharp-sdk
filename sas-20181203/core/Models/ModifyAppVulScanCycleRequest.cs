// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAppVulScanCycleRequest : TeaModel {
        /// <summary>
        /// <para>The scan cycle for application vulnerabilities.</para>
        /// <list type="bullet">
        /// <item><description>1week</description></item>
        /// <item><description>2weeks</description></item>
        /// <item><description>3days</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1week</para>
        /// </summary>
        [NameInMap("Cycle")]
        [Validation(Required=false)]
        public string Cycle { get; set; }

    }

}
