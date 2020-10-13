// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetBalanceBandwidthDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetBalanceBandwidthDataResponseDataList DataList { get; set; }
        public class GetBalanceBandwidthDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetBalanceBandwidthDataResponseDataListUsageData> UsageData { get; set; }
            public class GetBalanceBandwidthDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetBalanceBandwidthDataResponseDataListUsageDataValues Values { get; set; }
                public class GetBalanceBandwidthDataResponseDataListUsageDataValues : TeaModel {
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
        public GetBalanceBandwidthDataResponseLabels Labels { get; set; }
        public class GetBalanceBandwidthDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
