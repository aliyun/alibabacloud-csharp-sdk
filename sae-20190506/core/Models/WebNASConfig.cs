// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebNASConfig : TeaModel {
        /// <summary>
        /// <para>The mount targets.</para>
        /// </summary>
        [NameInMap("MountPoints")]
        [Validation(Required=false)]
        public List<WebNASMountPoint> MountPoints { get; set; }

    }

}
