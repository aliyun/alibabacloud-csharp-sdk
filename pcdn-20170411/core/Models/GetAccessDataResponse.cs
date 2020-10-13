// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetAccessDataResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=true)]
        public GetAccessDataResponseDataList DataList { get; set; }
        public class GetAccessDataResponseDataList : TeaModel {
            [NameInMap("UsageData")]
            [Validation(Required=true)]
            public List<GetAccessDataResponseDataListUsageData> UsageData { get; set; }
            public class GetAccessDataResponseDataListUsageData : TeaModel {
                public string Date { get; set; }
                public GetAccessDataResponseDataListUsageDataValues Values { get; set; }
                public class GetAccessDataResponseDataListUsageDataValues : TeaModel {
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
        public GetAccessDataResponseLabels Labels { get; set; }
        public class GetAccessDataResponseLabels : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=true)]
            public List<string> Label { get; set; }
        };

    }

}
