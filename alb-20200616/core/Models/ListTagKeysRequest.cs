// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListTagKeysRequest : TeaModel {
        /// <summary>
        /// The type of the tag.
        /// 
        /// Valid values: **Custom**, **System**, and **All**.
        /// 
        /// Default value: **All**.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The tag key. The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   **acl**: an access control list (ACL)
        /// *   **loadbalancer**: an Application Load Balancer (ALB) instance
        /// *   **securitypolicy**: a security policy
        /// *   **servergroup**: a server group
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
