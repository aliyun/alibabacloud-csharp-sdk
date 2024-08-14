// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DescribeHubClusterKubeconfigRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to obtain the kubeconfig file that is used to connect to the cluster over the internal network. Valid values:
        /// 
        /// *   `true`: obtains the kubeconfig file that is used to connect to the master instance over the internal network.
        /// *   `false`: obtains the kubeconfig file that is used to connect to the master instance over the Internet.
        /// 
        /// Default value: `false`
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

    }

}
