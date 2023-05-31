// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerCriteriaRequest : TeaModel {
        /// <summary>
        /// The filter condition. Valid values:
        /// 
        /// *   **pod**: pod
        /// *   **appName**: application name
        /// *   **clusterId**: cluster ID
        /// *   **namespace**: namespace
        /// *   **image**: image
        /// *   **containerScan**: container scan
        /// </summary>
        [NameInMap("GroupField")]
        [Validation(Required=false)]
        public string GroupField { get; set; }

        /// <summary>
        /// The value of the filter condition. The value can be an application name, node name, namespace, cluster name, public IP address, pod address, region, pod, instance ID, cluster ID, or container ID. Fuzzy match is supported.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
