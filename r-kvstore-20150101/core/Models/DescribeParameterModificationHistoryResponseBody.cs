// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterModificationHistoryResponseBody : TeaModel {
        /// <summary>
        /// Details of the parameter modification records.
        /// </summary>
        [NameInMap("HistoricalParameters")]
        [Validation(Required=false)]
        public DescribeParameterModificationHistoryResponseBodyHistoricalParameters HistoricalParameters { get; set; }
        public class DescribeParameterModificationHistoryResponseBodyHistoricalParameters : TeaModel {
            [NameInMap("HistoricalParameter")]
            [Validation(Required=false)]
            public List<DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter> HistoricalParameter { get; set; }
            public class DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter : TeaModel {
                /// <summary>
                /// The time when the parameter was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The parameter value after modification.
                /// </summary>
                [NameInMap("NewParameterValue")]
                [Validation(Required=false)]
                public string NewParameterValue { get; set; }

                /// <summary>
                /// The parameter value before modification.
                /// </summary>
                [NameInMap("OldParameterValue")]
                [Validation(Required=false)]
                public string OldParameterValue { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
