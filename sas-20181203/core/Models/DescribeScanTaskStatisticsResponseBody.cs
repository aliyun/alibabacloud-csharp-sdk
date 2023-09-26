// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScanTaskStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The number of risks that are handled for the user.
        /// </summary>
        [NameInMap("DealedRiskNum")]
        [Validation(Required=false)]
        public int? DealedRiskNum { get; set; }

        /// <summary>
        /// The total number of tasks that are created for the user.
        /// </summary>
        [NameInMap("PersonalTaskNum")]
        [Validation(Required=false)]
        public long? PersonalTaskNum { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of virus detection tasks.
        /// </summary>
        [NameInMap("TotalTaskNum")]
        [Validation(Required=false)]
        public long? TotalTaskNum { get; set; }

        /// <summary>
        /// The number of risks that are detected for the user.
        /// </summary>
        [NameInMap("UserNum")]
        [Validation(Required=false)]
        public long? UserNum { get; set; }

    }

}
