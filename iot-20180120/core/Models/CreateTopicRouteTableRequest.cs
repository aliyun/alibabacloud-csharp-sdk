// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateTopicRouteTableRequest : TeaModel {
        [NameInMap("DstTopic")]
        [Validation(Required=false)]
        public List<string> DstTopic { get; set; }

        /// <summary>
        /// The ID of the instance. You can view the instance **ID** on the **Overview** page in the IoT Platform console.
        /// 
        /// >*   If your instance has an ID, you must configure this parameter. If you do not set this parameter, the call fails.
        /// >*   If your instance has no **Overview** page or ID, you do not need to set this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The source topic. Example: `SrcTopic=/x7aWKW9 ****** /testDataToDataHub/user/update`.
        /// </summary>
        [NameInMap("SrcTopic")]
        [Validation(Required=false)]
        public string SrcTopic { get; set; }

    }

}
