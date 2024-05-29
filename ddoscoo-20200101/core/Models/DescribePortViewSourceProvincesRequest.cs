// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceProvincesRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you do not configure this parameter, the current system time is used as the end time.
        /// 
        /// > This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The IDs of instances to query.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](https://help.aliyun.com/document_detail/94485.html).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// > This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
