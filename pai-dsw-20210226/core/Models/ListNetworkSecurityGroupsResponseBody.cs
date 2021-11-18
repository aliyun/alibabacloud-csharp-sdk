// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class ListNetworkSecurityGroupsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// security groups
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public List<SecurityGroup> SecurityGroups { get; set; }

    }

}
