// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DisableMaintainWindowResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the paused silence policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ff3fbd0-8a0b-4b31-9b1c-8e3f0a2c5d71</para>
        /// </summary>
        [NameInMap("maintainWindowId")]
        [Validation(Required=false)]
        public string MaintainWindowId { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID for troubleshooting and ticket tracking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
