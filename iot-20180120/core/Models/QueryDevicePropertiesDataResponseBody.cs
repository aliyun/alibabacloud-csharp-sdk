// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertiesDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextTime")]
        [Validation(Required=false)]
        public long? NextTime { get; set; }

        [NameInMap("NextValid")]
        [Validation(Required=false)]
        public bool? NextValid { get; set; }

        [NameInMap("PropertyDataInfos")]
        [Validation(Required=false)]
        public QueryDevicePropertiesDataResponseBodyPropertyDataInfos PropertyDataInfos { get; set; }
        public class QueryDevicePropertiesDataResponseBodyPropertyDataInfos : TeaModel {
            [NameInMap("PropertyDataInfo")]
            [Validation(Required=false)]
            public List<QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfo> PropertyDataInfo { get; set; }
            public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfo : TeaModel {
                public string Identifier { get; set; }
                public QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoList List { get; set; }
                public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoList : TeaModel {
                    [NameInMap("PropertyInfo")]
                    [Validation(Required=false)]
                    public List<QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoListPropertyInfo> PropertyInfo { get; set; }
                    public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoListPropertyInfo : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
