// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UninstallSoftwaresShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the software systems that you want to uninstall.
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

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
