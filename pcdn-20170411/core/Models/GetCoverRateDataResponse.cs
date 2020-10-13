// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetCoverRateDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetCoverRateDataResponseDataList DataList { get; set; }
        public class GetCoverRateDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetCoverRateDataResponseDataListUsageData> UsageData { get; set; }
            public class GetCoverRateDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetCoverRateDataResponseDataListUsageDataValues Values { get; set; }
                public class GetCoverRateDataResponseDataListUsageDataValues : TeaModel {
                    /// <summary>
                    /// Values
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=true)]
                    public List<string> Values { get; set; }

                }
            }
        };

        [NameInMap("Labels")]
        [Validation(Required=true)]
        public GetCoverRateDataResponseLabels Labels { get; set; }
        public class GetCoverRateDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
