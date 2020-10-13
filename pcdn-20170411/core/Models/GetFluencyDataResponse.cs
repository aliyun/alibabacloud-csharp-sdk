// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetFluencyDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetFluencyDataResponseDataList DataList { get; set; }
        public class GetFluencyDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetFluencyDataResponseDataListUsageData> UsageData { get; set; }
            public class GetFluencyDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetFluencyDataResponseDataListUsageDataValues Values { get; set; }
                public class GetFluencyDataResponseDataListUsageDataValues : TeaModel {
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
        public GetFluencyDataResponseLabels Labels { get; set; }
        public class GetFluencyDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
