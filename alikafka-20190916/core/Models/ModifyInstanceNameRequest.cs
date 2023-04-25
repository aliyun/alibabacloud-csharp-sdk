// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ModifyInstanceNameRequest : TeaModel {
        /// <summary>
        /// The region ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The HTTP status code returned. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// The name of the instance. Valid values:
        /// 
        /// *   The name can contain only letters, digits, hyphens (-), and underscores (\_).
        /// *   The name must be 3 to 64 characters in length. If the name that you specify contains more than 64 characters, the system automatically truncates the name to 64 characters.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
