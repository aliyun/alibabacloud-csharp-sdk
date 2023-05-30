// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class UntagResourceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags. This parameter takes effect only when no tag key is specified. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the resource.
        /// 
        /// > You can use the value of this parameter to query the information about the resource, such as the account, service, and region information of the resource. You can manage tags only for services for top level resources.
        /// </summary>
        [NameInMap("resourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// The keys of the tags that you want to remove.
        /// </summary>
        [NameInMap("tagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
