// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeStsGrantStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not configure this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The name of the RAM role to query. Set the value to **AliyunDDoSCOODefaultRole**, which indicates the default role of Anti-DDoS Pro or Anti-DDoS Premium.
        /// 
        /// > Anti-DDoS Pro or Anti-DDoS Premium uses the default role to access other cloud services.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
