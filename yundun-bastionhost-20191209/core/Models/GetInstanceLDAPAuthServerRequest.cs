// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceLDAPAuthServerRequest : TeaModel {
        /// <summary>
        /// Indicates whether passwords are required. Valid values:
        /// 
        /// *   **true**: required
        /// *   **false**: not required
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetInstanceLDAPAuthServer**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
