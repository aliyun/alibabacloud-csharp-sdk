// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeLogisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Logistics")]
        [Validation(Required=false)]
        public DescribeLogisticsResponseBodyLogistics Logistics { get; set; }
        public class DescribeLogisticsResponseBodyLogistics : TeaModel {
            [NameInMap("LogisticsInfo")]
            [Validation(Required=false)]
            public List<DescribeLogisticsResponseBodyLogisticsLogisticsInfo> LogisticsInfo { get; set; }
            public class DescribeLogisticsResponseBodyLogisticsLogisticsInfo : TeaModel {
                [NameInMap("AcceptStatus")]
                [Validation(Required=false)]
                public bool? AcceptStatus { get; set; }

                [NameInMap("ApMacList")]
                [Validation(Required=false)]
                public string ApMacList { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EslMacList")]
                [Validation(Required=false)]
                public string EslMacList { get; set; }

                [NameInMap("HasSend")]
                [Validation(Required=false)]
                public string HasSend { get; set; }

                [NameInMap("LogisticsDocuments")]
                [Validation(Required=false)]
                public string LogisticsDocuments { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("PoNumber")]
                [Validation(Required=false)]
                public string PoNumber { get; set; }

                [NameInMap("PrNumber")]
                [Validation(Required=false)]
                public string PrNumber { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
