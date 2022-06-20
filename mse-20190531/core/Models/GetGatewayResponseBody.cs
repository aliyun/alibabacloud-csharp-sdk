// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayResponseBodyData Data { get; set; }
        public class GetGatewayResponseBodyData : TeaModel {
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("GatewayUniqueId")]
            [Validation(Required=false)]
            public string GatewayUniqueId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("LogConfigDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataLogConfigDetails LogConfigDetails { get; set; }
            public class GetGatewayResponseBodyDataLogConfigDetails : TeaModel {
                [NameInMap("LogEnabled")]
                [Validation(Required=false)]
                public bool? LogEnabled { get; set; }

                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("Replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }
            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public string Vpc { get; set; }
            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }
            [NameInMap("Vswitch2")]
            [Validation(Required=false)]
            public string Vswitch2 { get; set; }
            [NameInMap("XtraceDetails")]
            [Validation(Required=false)]
            public GetGatewayResponseBodyDataXtraceDetails XtraceDetails { get; set; }
            public class GetGatewayResponseBodyDataXtraceDetails : TeaModel {
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public int? Sample { get; set; }

                [NameInMap("TraceOn")]
                [Validation(Required=false)]
                public bool? TraceOn { get; set; }

            }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
