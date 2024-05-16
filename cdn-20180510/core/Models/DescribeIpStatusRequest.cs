// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpStatusRequest : TeaModel {
        /// <summary>
        /// The IP addresses that you want to query. Separate IP addresses with underscores (_), such as Ips=ip1_ip2.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

    }

}
