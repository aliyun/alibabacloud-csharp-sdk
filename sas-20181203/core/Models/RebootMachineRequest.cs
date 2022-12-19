// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RebootMachineRequest : TeaModel {
        /// <summary>
        /// The UUID of the server that you want to restart.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~describecloudcenterinstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
