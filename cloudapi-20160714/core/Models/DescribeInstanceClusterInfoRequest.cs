// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceClusterInfoRequest : TeaModel {
        /// <summary>
        /// The name of the dedicated instance cluster.
        /// </summary>
        [NameInMap("InstanceClusterName")]
        [Validation(Required=false)]
        public string InstanceClusterName { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
