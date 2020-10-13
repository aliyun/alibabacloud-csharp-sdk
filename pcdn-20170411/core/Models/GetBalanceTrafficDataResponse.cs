// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetBalanceTrafficDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetBalanceTrafficDataResponseDataList DataList { get; set; }
        public class GetBalanceTrafficDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetBalanceTrafficDataResponseDataListUsageData> UsageData { get; set; }
            public class GetBalanceTrafficDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetBalanceTrafficDataResponseDataListUsageDataValues Values { get; set; }
                public class GetBalanceTrafficDataResponseDataListUsageDataValues : TeaModel {
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
        public GetBalanceTrafficDataResponseLabels Labels { get; set; }
        public class GetBalanceTrafficDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
