// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// The kubeconfig file of the cluster. For more information about the content of the kubeconfig file, see [Configure cluster credentials](https://help.aliyun.com/document_detail/86494.html).
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// The validity period of the kubeconfig file. The value is the UTC time displayed in RFC3339 format.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
