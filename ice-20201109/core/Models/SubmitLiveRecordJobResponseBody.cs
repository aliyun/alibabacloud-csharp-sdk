// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveRecordJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ab0e3e76-1e9d-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA98A0C-7870-15FE-B96F-8880BB600A2C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
