// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDesiredPropertyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceDesiredPropertyResponseBodyData Data { get; set; }
        public class QueryDeviceDesiredPropertyResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceDesiredPropertyResponseBodyDataList List { get; set; }
            public class QueryDeviceDesiredPropertyResponseBodyDataList : TeaModel {
                [NameInMap("DesiredPropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceDesiredPropertyResponseBodyDataListDesiredPropertyInfo> DesiredPropertyInfo { get; set; }
                public class QueryDeviceDesiredPropertyResponseBodyDataListDesiredPropertyInfo : TeaModel {
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public long? Version { get; set; }

                }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
