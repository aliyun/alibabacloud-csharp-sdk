// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetResourceTagsRequest : TeaModel {
        /// <summary>
        /// The ARN of the resource. 
        /// > **Note:** You can use the value of this parameter to query the information about the resource, such as the account, service, and region information of the resource.
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

    }

}
