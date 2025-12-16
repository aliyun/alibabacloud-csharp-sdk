// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class GetPassThroughAuthInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mm_2b7d37b695fb44faa983e5fbb032</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35f9ed99b27a1e8374f6593bf969f7d6</para>
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

    }

}
