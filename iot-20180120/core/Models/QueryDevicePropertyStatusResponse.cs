// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertyStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDevicePropertyStatusResponseData Data { get; set; }
        public class QueryDevicePropertyStatusResponseData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=true)]
            public QueryDevicePropertyStatusResponseDataList List { get; set; }
            public class QueryDevicePropertyStatusResponseDataList : TeaModel {
                [NameInMap("PropertyStatusInfo")]
                [Validation(Required=true)]
                public List<QueryDevicePropertyStatusResponseDataListPropertyStatusInfo> PropertyStatusInfo { get; set; }
                public class QueryDevicePropertyStatusResponseDataListPropertyStatusInfo : TeaModel {
                    [NameInMap("Unit")]
                    [Validation(Required=true)]
                    public string Unit { get; set; }

                    [NameInMap("Identifier")]
                    [Validation(Required=true)]
                    public string Identifier { get; set; }

                    [NameInMap("DataType")]
                    [Validation(Required=true)]
                    public string DataType { get; set; }

                    [NameInMap("Time")]
                    [Validation(Required=true)]
                    public string Time { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=true)]
                    public string Value { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

            }
        };

    }

}
