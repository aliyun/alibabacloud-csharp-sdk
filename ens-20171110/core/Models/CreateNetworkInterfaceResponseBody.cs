// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkInterfaceResponseBody : TeaModel {
        [NameInMap("NetworkInterfaceIds")]
        [Validation(Required=false)]
        public List<string> NetworkInterfaceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F3B261DD-3858-4D3C-877D-303ADF374600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
