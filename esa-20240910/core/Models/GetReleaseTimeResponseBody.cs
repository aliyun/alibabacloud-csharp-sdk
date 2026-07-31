// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetReleaseTimeResponseBody : TeaModel {
        /// <summary>
        /// <para>The scheduled release time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T06:00:00Z</para>
        /// </summary>
        [NameInMap("ReleaseTime")]
        [Validation(Required=false)]
        public string ReleaseTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6abd807e-ed2a-****-ac54-ac38a62472e6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
