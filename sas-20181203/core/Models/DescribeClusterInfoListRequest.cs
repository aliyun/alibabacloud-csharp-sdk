// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterInfoListRequest : TeaModel {
        /// <summary>
        /// The operation value. The value specifies the ID of the cluster.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The dimension based on which you want to configure the feature. Valid values:
        /// 
        /// *   **Cluster**: the ID of the cluster
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// The type of the feature. Valid values:
        /// 
        /// *   **containerNetwork**: container network
        /// *   **interceptionSwitch**: cluster microsegmentation
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
