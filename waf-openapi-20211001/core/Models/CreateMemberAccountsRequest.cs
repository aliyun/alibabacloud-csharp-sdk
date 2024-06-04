// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateMemberAccountsRequest : TeaModel {
        /// <summary>
        /// The ID of the WAF instance.
        /// 
        /// >  You can call the [DescribeInstance](https://help.aliyun.com/document_detail/433756.html) operation to query the ID of the WAF instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The Alibaba Cloud account IDs of the members that you want to add. You can add up to 10 members at the same time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MemberAccountIds")]
        [Validation(Required=false)]
        public List<string> MemberAccountIds { get; set; }

        /// <summary>
        /// The region in which the WAF instance is deployed. Valid values:
        /// 
        /// *   **cn-hangzhou**: Chinese mainland.
        /// *   **ap-southeast-1**: outside the Chinese mainland.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The source IP address of the request. The system automatically obtains the value of this parameter.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
