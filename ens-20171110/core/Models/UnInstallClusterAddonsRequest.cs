// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnInstallClusterAddonsRequest : TeaModel {
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<UnInstallClusterAddonsRequestAddons> Addons { get; set; }
        public class UnInstallClusterAddonsRequestAddons : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>edge-csi-lite</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eck-xxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
