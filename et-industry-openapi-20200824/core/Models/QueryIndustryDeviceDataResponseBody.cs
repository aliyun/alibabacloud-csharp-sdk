// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Et_industry_openapi20200824.Models
{
    public class QueryIndustryDeviceDataResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public QueryIndustryDeviceDataResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class QueryIndustryDeviceDataResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryIndustryDeviceDataResponseBodyData> Data { get; set; }
        public class QueryIndustryDeviceDataResponseBodyData : TeaModel {
            [NameInMap("MeasurePoint")]
            [Validation(Required=false)]
            public string MeasurePoint { get; set; }

            [NameInMap("Node")]
            [Validation(Required=false)]
            public string Node { get; set; }

            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<QueryIndustryDeviceDataResponseBodyDataValues> Values { get; set; }
            public class QueryIndustryDeviceDataResponseBodyDataValues : TeaModel {
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                [NameInMap("ProcessTime")]
                [Validation(Required=false)]
                public string ProcessTime { get; set; }

                [NameInMap("Quality")]
                [Validation(Required=false)]
                public int? Quality { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public long? TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
