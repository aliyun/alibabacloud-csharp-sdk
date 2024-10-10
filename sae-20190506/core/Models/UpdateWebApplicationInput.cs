// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebApplicationInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sae-app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

    }

}
