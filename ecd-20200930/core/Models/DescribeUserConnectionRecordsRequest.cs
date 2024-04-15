// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsRequest : TeaModel {
        /// <summary>
        /// The duration when the cloud desktop is connected, which is the minimum value for condition filtering.
        /// </summary>
        [NameInMap("ConnectDurationFrom")]
        [Validation(Required=false)]
        public long? ConnectDurationFrom { get; set; }

        /// <summary>
        /// The duration when the cloud desktop is connected, which is the maximum value for condition filtering.
        /// </summary>
        [NameInMap("ConnectDurationTo")]
        [Validation(Required=false)]
        public long? ConnectDurationTo { get; set; }

        /// <summary>
        /// The time when the cloud desktop stops to be connected, which is the minimum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ConnectEndTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectEndTimeFrom { get; set; }

        /// <summary>
        /// The time when the cloud desktop stops to be connected, which is the maximum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ConnectEndTimeTo")]
        [Validation(Required=false)]
        public long? ConnectEndTimeTo { get; set; }

        /// <summary>
        /// The time when the cloud desktop starts to be connected, which is the minimum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ConnectStartTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectStartTimeFrom { get; set; }

        /// <summary>
        /// The time when the cloud desktop starts to be connected, which is the maximum value for condition filtering. The value is a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("ConnectStartTimeTo")]
        [Validation(Required=false)]
        public long? ConnectStartTimeTo { get; set; }

        /// <summary>
        /// The ID of the cloud computer pool.
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// The ID of the cloud computer.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The ID of the authorized user.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The type of the user account.
        /// 
        /// Valid values:
        /// 
        /// *   SIMPLE: convenience account
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   AD_CONNECTOR: enterprise AD account
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EndUserType")]
        [Validation(Required=false)]
        public string EndUserType { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
