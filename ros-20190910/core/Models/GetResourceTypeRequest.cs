// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeRequest : TeaModel {
        /// <summary>
        /// The type of the resource.
        /// 
        /// For more information about resource types supported by Resource Orchestration Service (ROS), see [List of resource types by service](~~127039~~).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
