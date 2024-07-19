// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteResourceInstancesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete all the instances that fail to be created. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("AllFailed")]
        [Validation(Required=false)]
        public bool? AllFailed { get; set; }

        /// <summary>
        /// The instances. Separate multiple instances with commas (,), such as `instanceId1,instanceId2`. For more information about how to query the instances, see [ListResourceInstances](https://help.aliyun.com/document_detail/412129.html).
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public string InstanceList { get; set; }

    }

}
