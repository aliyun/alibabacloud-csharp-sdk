// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigResponseBody : TeaModel {
        /// <summary>
        /// The content of the KubeConfig file. For more information about the content of the KubeConfig file, see [Configure cluster credentials](~~86494~~).
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The expiration time of the KubeConfig file. The value is the UTC time displayed in RFC3339 format.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
