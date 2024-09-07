// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UninstallSoftwaresRequest : TeaModel {
        /// <summary>
        /// The information about the software systems that you want to uninstall.
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public List<UninstallSoftwaresRequestAdditionalPackages> AdditionalPackages { get; set; }
        public class UninstallSoftwaresRequestAdditionalPackages : TeaModel {
            /// <summary>
            /// The software name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The software version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](https://help.aliyun.com/document_detail/87116.html) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
