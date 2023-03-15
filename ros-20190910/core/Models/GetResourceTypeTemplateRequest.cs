// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeTemplateRequest : TeaModel {
        /// <summary>
        /// The resource type.
        /// 
        /// You can call the [ListResourceTypes](~~133957~~) operation to query the resource type.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
