// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigRequest : TeaModel {
        /// <summary>
        /// Specifies whether to obtain the kubeconfig file used to connect to the cluster over the internal network. Valid values:
        /// 
        /// *   `true`: Obtain the kubeconfig file used to connect to the cluster over the internal network.
        /// *   `false`: Obtain the kubeconfig file used to connect to the cluster over the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// The validity period of the temporary kubeconfig file. Unit: minutes.
        /// 
        /// Valid values: 15 to 4320 (three days).
        /// 
        /// > If you leave this parameter empty, the system sets a longer validity period and returns the value in the expiration parameter of the response.
        /// </summary>
        [NameInMap("TemporaryDurationMinutes")]
        [Validation(Required=false)]
        public long? TemporaryDurationMinutes { get; set; }

    }

}
