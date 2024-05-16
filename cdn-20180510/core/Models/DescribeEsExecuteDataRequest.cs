// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeEsExecuteDataRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the rule. You can call the [DescribeCdnDomainConfigs](https://help.aliyun.com/document_detail/90924.html) operation to query script IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
