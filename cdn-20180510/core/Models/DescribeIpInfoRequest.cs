// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpInfoRequest : TeaModel {
        /// <summary>
        /// The IP address. You can specify only one IP address.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

    }

}
