// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpStatusRequest : TeaModel {
        /// <summary>
        /// The IP addresses that you want to query. Separate IP addresses with underscores (\_), such as Ips=ip1\_ip2.
        /// </summary>
        [NameInMap("Ips")]
        [Validation(Required=false)]
        public string Ips { get; set; }

    }

}
