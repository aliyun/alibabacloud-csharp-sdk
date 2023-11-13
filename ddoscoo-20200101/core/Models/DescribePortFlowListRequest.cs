// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortFlowListRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// **
        /// 
        /// **This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// An array that consists of the IDs of instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The interval for returning data. Unit: seconds. The interval that you can specify varies based on the time range to query. The time range to query is determined by the values of **StartTime** and **EndTime**.
        /// 
        /// *   If the time range to query is no greater than 1 hour, we recommend that you specify the interval from 60 seconds to the time range to query.
        /// *   If the time range to query is greater than 1 hour but no greater than 6 hours, we recommend that you specify the interval from 600 seconds to the time range to query.
        /// *   If the time range to query is greater than 6 hours but no greater than 24 hours, we recommend that you specify the interval from 1,800 seconds to the time range to query.
        /// *   If the time range to query is greater than 24 hours but no greater than 7 days, we recommend that you specify the interval from 3,600 seconds to the time range to query.
        /// *   If the time range to query is greater than 7 days but no greater than 15 days, we recommend that you specify the interval from 14,400 seconds to the time range to query.
        /// *   If the time range to query is greater than 15 days, we recommend that you specify the interval from 43,200 seconds to the time range to query.
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// 
        /// For more information about resource groups, see [Create a resource group](~~94485~~).
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds.
        /// 
        /// **
        /// 
        /// **This UNIX timestamp must indicate a point in time that is accurate to the minute.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
