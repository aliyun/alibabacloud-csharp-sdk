// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigResponseBody : TeaModel {
        /// <summary>
        /// The cluster kubeconfig file. For more information about the content of the kubeconfig file, see [Configure cluster credentials](https://help.aliyun.com/document_detail/86494.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The expiration date of the kubeconfig file. The value is the UTC time displayed in RFC3339 format.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
