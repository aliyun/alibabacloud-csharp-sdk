// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OpenSensitiveFileScanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable or disable sensitive file scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables sensitive file scan</description></item>
        /// <item><description><b>off</b>: disables sensitive file scan</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("SwitchOn")]
        [Validation(Required=false)]
        public string SwitchOn { get; set; }

    }

}
