// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDesiredPropertyResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceDesiredPropertyResponseData Data { get; set; }
        public class QueryDeviceDesiredPropertyResponseData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDeviceDesiredPropertyResponseDataList List { get; set; }
            public class QueryDeviceDesiredPropertyResponseDataList : TeaModel {
                [NameInMap("DesiredPropertyInfo")]
                [Validation(Required=true)]
                public List<QueryDeviceDesiredPropertyResponseDataListDesiredPropertyInfo> DesiredPropertyInfo { get; set; }
                public class QueryDeviceDesiredPropertyResponseDataListDesiredPropertyInfo : TeaModel {
                    [NameInMap("DataType")]
                    [Validation(Required=true)]
                    public string DataType { get; set; }

                    [NameInMap("Identifier")]
                    [Validation(Required=true)]
                    public string Identifier { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public string Time { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=true)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=true)]
                    public long? Version { get; set; }

                }

            }

        }

    }

}
