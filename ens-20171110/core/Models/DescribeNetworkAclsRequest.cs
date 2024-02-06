// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeNetworkAclsRequest : TeaModel {
        /// <summary>
        /// The ID of the network ACL.
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// The name of the network ACL.
        /// 
        /// The name must be 1 to 128 characters in length. The name cannot start with \*\*http:// **or** https://\*\*.
        /// </summary>
        [NameInMap("NetworkAclName")]
        [Validation(Required=false)]
        public string NetworkAclName { get; set; }

        /// <summary>
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The ID of the associated instance.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
