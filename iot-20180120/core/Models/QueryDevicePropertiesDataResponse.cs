// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertiesDataResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextTime")]
        [Validation(Required=true)]
        public long? NextTime { get; set; }

        [NameInMap("NextValid")]
        [Validation(Required=true)]
        public bool? NextValid { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("PropertyDataInfos")]
        [Validation(Required=true)]
        public QueryDevicePropertiesDataResponsePropertyDataInfos PropertyDataInfos { get; set; }
        public class QueryDevicePropertiesDataResponsePropertyDataInfos : TeaModel {
            [NameInMap("PropertyDataInfo")]
            [Validation(Required=true)]
            public List<QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfo> PropertyDataInfo { get; set; }
            public class QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfo : TeaModel {
                [NameInMap("Identifier")]
                [Validation(Required=true)]
                public string Identifier { get; set; }

                [NameInMap("List")]
                [Validation(Required=true)]
                public QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfoList List { get; set; }
                public class QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfoList : TeaModel {
                    [NameInMap("PropertyInfo")]
                    [Validation(Required=true)]
                    public List<QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfoListPropertyInfo> PropertyInfo { get; set; }
                    public class QueryDevicePropertiesDataResponsePropertyDataInfosPropertyDataInfoListPropertyInfo : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=true)]
                        public long? Time { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=true)]
                        public string Value { get; set; }

                    }

                }

            }

        }

    }

}
