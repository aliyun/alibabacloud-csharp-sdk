// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeOnDemandDdosEventRequest : TeaModel {
        /// <summary>
        /// The end time of the DDoS attack events to query. This value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The ID of the anti-DDoS diversion instance to query.
        /// 
        /// >  You can call the [DescribeOnDemandInstance](https://help.aliyun.com/document_detail/152120.html) operation to query the IDs of all anti-DDoS diversion instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the anti-DDoS diversion instance to query.
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: **50**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the anti-DDoS diversion instance to query.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Anti-DDoS Origin instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The start time of the DDoS attack events to query. This value is a UNIX timestamp. Unit: seconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
