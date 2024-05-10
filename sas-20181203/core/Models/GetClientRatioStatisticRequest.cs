// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetClientRatioStatisticRequest : TeaModel {
        /// <summary>
        /// The ID of the primary account of the Resource Directory member account.
        /// > call the [DescribeMonitorAccounts](~~DescribeMonitorAccounts~~) interface to obtain this parameter.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// An array that consists of the details of a statistical type.
        /// </summary>
        [NameInMap("StatisticTypes")]
        [Validation(Required=false)]
        public List<string> StatisticTypes { get; set; }

        /// <summary>
        /// The timestamp that specifies the end of the time range to collect statistics. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// The timestamp that specifies the beginning of the time range to collect statistics. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
