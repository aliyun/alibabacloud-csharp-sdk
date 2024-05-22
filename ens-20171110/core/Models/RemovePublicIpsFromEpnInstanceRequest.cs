// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemovePublicIpsFromEpnInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the EPN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EPNInstanceId")]
        [Validation(Required=false)]
        public string EPNInstanceId { get; set; }

        /// <summary>
        /// The information about the public IP addresses that you want to delete.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceInfos")]
        [Validation(Required=false)]
        public string InstanceInfos { get; set; }

    }

}
