// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RetryInstallProbeRequest : TeaModel {
        /// <summary>
        /// <para>The probe ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListHoneypotProbe~~">ListHoneypotProbe</a> operation to query the IDs of probes.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c4c47cc1-f60a-4b2f-bcdb-9aed6644****</para>
        /// </summary>
        [NameInMap("ProbeId")]
        [Validation(Required=false)]
        public string ProbeId { get; set; }

    }

}
