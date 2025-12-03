// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class BindVscMountPointAliasResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>sdfe</para>
        /// </summary>
        [NameInMap("MountPointAlias")]
        [Validation(Required=false)]
        public string MountPointAlias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>55C5FFD6-BF99-41BD-9C66-FFF39189****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
