// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetTrafficDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetTrafficDataResponseDataList DataList { get; set; }
        public class GetTrafficDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetTrafficDataResponseDataListUsageData> UsageData { get; set; }
            public class GetTrafficDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetTrafficDataResponseDataListUsageDataValues Values { get; set; }
                public class GetTrafficDataResponseDataListUsageDataValues : TeaModel {
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
        public GetTrafficDataResponseLabels Labels { get; set; }
        public class GetTrafficDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
