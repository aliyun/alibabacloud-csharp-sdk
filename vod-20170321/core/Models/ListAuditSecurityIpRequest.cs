// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAuditSecurityIpRequest : TeaModel {
        /// <summary>
        /// The name of the review security group where you want to query IP addresses. If you do not set this parameter, IP addresses in all review security groups are queried.
        /// </summary>
        [NameInMap("SecurityGroupName")]
        [Validation(Required=false)]
        public string SecurityGroupName { get; set; }

    }

}
