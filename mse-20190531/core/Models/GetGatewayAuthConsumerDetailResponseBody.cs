// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetGatewayAuthConsumerDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetGatewayAuthConsumerDetailResponseBodyData Data { get; set; }
        public class GetGatewayAuthConsumerDetailResponseBodyData : TeaModel {
            [NameInMap("ConsumerStatus")]
            [Validation(Required=false)]
            public bool? ConsumerStatus { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

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

            [NameInMap("Jwks")]
            [Validation(Required=false)]
            public string Jwks { get; set; }

            [NameInMap("KeyName")]
            [Validation(Required=false)]
            public string KeyName { get; set; }

            [NameInMap("KeyValue")]
            [Validation(Required=false)]
            public string KeyValue { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetGatewayAuthConsumerDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetGatewayAuthConsumerDetailResponseBodyDataResourceList : TeaModel {
                [NameInMap("ConsumerId")]
                [Validation(Required=false)]
                public long? ConsumerId { get; set; }

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

                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public bool? ResourceStatus { get; set; }

                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

            }

            [NameInMap("TokenName")]
            [Validation(Required=false)]
            public string TokenName { get; set; }

            [NameInMap("TokenPass")]
            [Validation(Required=false)]
            public bool? TokenPass { get; set; }

            [NameInMap("TokenPosition")]
            [Validation(Required=false)]
            public string TokenPosition { get; set; }

            [NameInMap("TokenPrefix")]
            [Validation(Required=false)]
            public string TokenPrefix { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

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
