// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyVpcAccessAndUpdateApisResponseBody : TeaModel {
        /// <summary>
        /// The ID of the asynchronous task.
        /// 
        /// > 
        /// 
        /// *   If the associated API is updated, you can use the task ID in the **DescribeUpdateVpcInfoTask** operation to query the update result.
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
