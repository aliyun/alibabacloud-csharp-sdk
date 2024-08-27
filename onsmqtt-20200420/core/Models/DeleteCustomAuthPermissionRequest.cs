// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class DeleteCustomAuthPermissionRequest : TeaModel {
        /// <summary>
        /// The username or client ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        /// <summary>
        /// The identity type. Valid values:
        /// 
        /// *   USER
        /// *   CLIENT
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// The ID of the ApsaraMQ for MQTT instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The topic on which you want to grant permissions. Multi-level topics and Wildcard characters are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
