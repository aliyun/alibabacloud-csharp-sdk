// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyAclEntriesRequest : TeaModel {
        /// <summary>
        /// The Internet access control policy.
        /// 
        /// Valid values:
        /// 
        /// *   allow: allows access to the Internet.
        /// 
        /// *   disable: forbids access to the Internet.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/196646.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The instance IDs (office network IDs or cloud computer IDs) to which the Internet access control policy is applicable.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// The granularity to which the Internet access control policy is applicable.
        /// 
        /// Valid values:
        /// 
        /// *   desktop: cloud computer granularity.
        /// 
        /// *   vpc: office network granularity.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
