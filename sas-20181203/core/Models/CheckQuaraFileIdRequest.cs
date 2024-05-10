// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckQuaraFileIdRequest : TeaModel {
        /// <summary>
        /// The IDs of quarantined files that you want to check.
        /// 
        /// >  You can call the [DescribeSuspEventQuaraFiles](~~DescribeSuspEventQuaraFiles~~) operation to query the IDs of quarantined files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QuaraFileIds")]
        [Validation(Required=false)]
        public List<string> QuaraFileIds { get; set; }

        /// <summary>
        /// The UUID of the server on which you want to check quarantined files.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
