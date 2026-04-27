// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateUnknownThreatDetectProcessRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026011210040602108912721603151374234</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
