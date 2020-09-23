// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigRequest : TeaModel {
        /// <summary>
        /// ApiServer是否为内网地址。
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

    }

}
