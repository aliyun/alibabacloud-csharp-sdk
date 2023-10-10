// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to obtain the kubeconfig file that is used to connect to the cluster over the internal network. Valid values:
        /// 
        /// *   `true`: obtains the kubeconfig file that is used to connect to the master instance over the internal network.
        /// *   `false`: obtains the kubeconfig file that is used to connect to the master instance over the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// The validity period of a temporary kubeconfig file. Unit: minutes. Valid values: 15 to 4320 (3 days).
        /// 
        /// >  If you do not specify this parameter, the system specifies a longer validity period. The validity period is returned in the `expiration` parameter.
        /// </summary>
        [NameInMap("TemporaryDurationMinutes")]
        [Validation(Required=false)]
        public long? TemporaryDurationMinutes { get; set; }

    }

}
