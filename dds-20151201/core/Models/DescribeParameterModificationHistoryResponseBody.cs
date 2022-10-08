// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeParameterModificationHistoryResponseBody : TeaModel {
        [NameInMap("HistoricalParameters")]
        [Validation(Required=false)]
        public DescribeParameterModificationHistoryResponseBodyHistoricalParameters HistoricalParameters { get; set; }
        public class DescribeParameterModificationHistoryResponseBodyHistoricalParameters : TeaModel {
            [NameInMap("HistoricalParameter")]
            [Validation(Required=false)]
            public List<DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter> HistoricalParameter { get; set; }
            public class DescribeParameterModificationHistoryResponseBodyHistoricalParametersHistoricalParameter : TeaModel {
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                [NameInMap("NewParameterValue")]
                [Validation(Required=false)]
                public string NewParameterValue { get; set; }

                [NameInMap("OldParameterValue")]
                [Validation(Required=false)]
                public string OldParameterValue { get; set; }

                [NameInMap("ParameterName")]
                [Validation(Required=false)]
                public string ParameterName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
