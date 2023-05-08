// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTotalStatisticsRequest : TeaModel {
        /// <summary>
        /// The source of data. Default value: **aqs**. Valid values:
        /// 
        /// *   **sas**: Security Center
        /// *   **aqs**: Server Guard
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the asset group.
        /// 
        /// > You can call the [DescribeAllGroups](~~130972~~) operation to query the IDs of asset groups.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The name or public IP address of the asset.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
