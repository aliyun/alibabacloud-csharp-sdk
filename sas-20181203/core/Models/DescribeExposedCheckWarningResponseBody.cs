// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedCheckWarningResponseBody : TeaModel {
        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the baseline risk items of the exposed server.
        /// </summary>
        [NameInMap("WarningList")]
        [Validation(Required=false)]
        public List<DescribeExposedCheckWarningResponseBodyWarningList> WarningList { get; set; }
        public class DescribeExposedCheckWarningResponseBodyWarningList : TeaModel {
            /// <summary>
            /// The ID of the baseline.
            /// 
            /// >  You can call the [DescribeCheckWarningSummary](https://help.aliyun.com/document_detail/116179.html) operation to query the IDs of baselines.
            /// </summary>
            [NameInMap("RiskId")]
            [Validation(Required=false)]
            public long? RiskId { get; set; }

            /// <summary>
            /// The name of the baseline.
            /// </summary>
            [NameInMap("RiskName")]
            [Validation(Required=false)]
            public string RiskName { get; set; }

            /// <summary>
            /// The display name of the baseline sub type.
            /// </summary>
            [NameInMap("SubTypeAlias")]
            [Validation(Required=false)]
            public string SubTypeAlias { get; set; }

            /// <summary>
            /// The display name of the baseline type.
            /// </summary>
            [NameInMap("TypeAlias")]
            [Validation(Required=false)]
            public string TypeAlias { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
