// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEndpointAttributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEndpointAttributeResponseBodyData Data { get; set; }
        public class GetEndpointAttributeResponseBodyData : TeaModel {
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<GetEndpointAttributeResponseBodyDataCidrList> CidrList { get; set; }
            public class GetEndpointAttributeResponseBodyDataCidrList : TeaModel {
                [NameInMap("AclStrategy")]
                [Validation(Required=false)]
                public string AclStrategy { get; set; }

                [NameInMap("Cidr")]
                [Validation(Required=false)]
                public string Cidr { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

            }

            [NameInMap("EndpointEnabled")]
            [Validation(Required=false)]
            public bool? EndpointEnabled { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
