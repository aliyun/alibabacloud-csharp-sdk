// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class InstallSoftwaresShrinkRequest : TeaModel {
        /// <summary>
        /// The information about the software systems that you want to install.
        /// </summary>
        [NameInMap("AdditionalPackages")]
        [Validation(Required=false)]
        public string AdditionalPackagesShrink { get; set; }

        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
