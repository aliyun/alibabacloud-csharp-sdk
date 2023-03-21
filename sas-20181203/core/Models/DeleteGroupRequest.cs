// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the server group that you want to delete.
        /// 
        /// >  To delete a server group, you must provide the ID of the server group. You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to query the ID.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
