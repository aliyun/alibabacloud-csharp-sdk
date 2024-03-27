// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CarbonFootprint20230711.Models
{
    public class QueryCarbonTrackRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format. Example: 2023-02-01 23:59:59.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// Whether to count the carbon emission details of multiple accounts. You can pass it in after opening the multi-account management. The default value and 0 is No and 1 is Yes.
        /// </summary>
        [NameInMap("FilterRDAccount")]
        [Validation(Required=false)]
        public int? FilterRDAccount { get; set; }

        /// <summary>
        /// The statistical dimension. A value of productCode specifies that statistics are collected based on cloud service. A value of region specifies that statistics are collected based on region. A value of subUid specifies that statistics are collected based on Resource Access Management (RAM) user. If you do not specify this parameter, statistics are collected based on Alibaba Cloud account.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the yyyy-MM-dd HH:mm:ss format. Example: 2023-01-01 00:00:00.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// After sorting in reverse order according to the data value of the return value, only the first TopNum data will be returned. If no data is passed, all data will be returned by default.
        /// </summary>
        [NameInMap("TopNum")]
        [Validation(Required=false)]
        public int? TopNum { get; set; }

        /// <summary>
        /// The list of Alibaba Cloud account IDs whose data needs to be queried.(used after enabling multi-account management).
        /// </summary>
        [NameInMap("Uids")]
        [Validation(Required=false)]
        public List<string> Uids { get; set; }

        /// <summary>
        /// Whether the return result uses code as the identifier(0 meas not used and 1 means used). If not passed, the default code is used.
        /// 
        /// For example, when the return result is to summarize carbon emissions according to the cloud product dimension, the identifier of ECS is "ecs" when 0 is passed, and "Elastic Compute Service" when 1 is passed.
        /// </summary>
        [NameInMap("UseCode")]
        [Validation(Required=false)]
        public int? UseCode { get; set; }

    }

}
