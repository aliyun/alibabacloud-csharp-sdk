// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDevicePropertyStatusResponseBodyData Data { get; set; }
        public class QueryDevicePropertyStatusResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDevicePropertyStatusResponseBodyDataList List { get; set; }
            public class QueryDevicePropertyStatusResponseBodyDataList : TeaModel {
                [NameInMap("PropertyStatusInfo")]
                [Validation(Required=false)]
                public List<QueryDevicePropertyStatusResponseBodyDataListPropertyStatusInfo> PropertyStatusInfo { get; set; }
                public class QueryDevicePropertyStatusResponseBodyDataListPropertyStatusInfo : TeaModel {
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
