// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandInstanceStatusRequest : TeaModel {
        /// <summary>
        /// The IDs of the anti-DDoS diversion instances.
        /// 
        /// >  You can call the [DescribeOnDemandInstance](https://help.aliyun.com/document_detail/152120.html) operation to query the IDs of all anti-DDoS diversion instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// The region ID of the anti-DDoS diversion instance.
        /// 
        /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query all regions that are supported by Anti-DDoS Origin.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
