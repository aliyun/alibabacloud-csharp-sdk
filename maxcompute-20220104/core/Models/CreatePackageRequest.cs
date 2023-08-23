/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreatePackageRequest : TeaModel {
        /// <summary>
        /// The request body parameters.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// Specifies whether to install the package.
        /// </summary>
        [NameInMap("isInstall")]
        [Validation(Required=false)]
        public bool? IsInstall { get; set; }

    }

}
