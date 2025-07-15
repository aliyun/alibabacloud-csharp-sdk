// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateRtcMPUEventSubResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the subscription.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sub-<b><b><b>9799B2C4500</b></b></b></para>
        /// </summary>
        [NameInMap("SubId")]
        [Validation(Required=false)]
        public string SubId { get; set; }

    }

}
