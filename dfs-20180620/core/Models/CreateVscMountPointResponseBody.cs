// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateVscMountPointResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>e389e5c7-bcb4-4558-846a-e5afc444****</para>
        /// </summary>
        [NameInMap("MountPointId")]
        [Validation(Required=false)]
        public string MountPointId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
