// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceUsageDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the account whose data you want to query. If you do not specify this parameter, the data of the current Alibaba Cloud account and its Resource Access Management (RAM) users is queried. To query the data of a RAM user, specify the ID of the RAM user.
        /// </summary>
        [NameInMap("BillOwnerId")]
        [Validation(Required=false)]
        public long? BillOwnerId { get; set; }

        /// <summary>
        /// The end of the time range to query. The end is excluded from the time range. If you do not set this parameter, the end time is the current time. Specify the time in the format of yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [NameInMap("EndPeriod")]
        [Validation(Required=false)]
        public string EndPeriod { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Default value: 20. The maximum value is 300.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The time granularity at which usage details are queried. Valid values: MONTH, DAY, and HOUR.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PeriodType")]
        [Validation(Required=false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// The type of deduction plan whose usage details are queried. Valid values: RI and SCU.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The beginning is included in the time range. Specify the time in the yyyy-MM-dd HH:mm:ss format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartPeriod")]
        [Validation(Required=false)]
        public string StartPeriod { get; set; }

    }

}
