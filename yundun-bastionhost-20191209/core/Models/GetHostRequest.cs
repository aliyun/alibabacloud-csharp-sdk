// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetHostRequest : TeaModel {
        /// <summary>
        /// The protocol that is used to connect to the host. Valid values:
        /// 
        /// *   **SSH**
        /// *   **RDP**
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// The ID of the host that you want to query. You can specify only one host ID.
        /// 
        /// >  You can call the [ListHosts](~~200665~~) operation to query the ID of the host.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
