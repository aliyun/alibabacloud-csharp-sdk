// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class UpdateGatewayApiGroupResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("ApiGroup")]
        [Validation(Required=false)]
        public UpdateGatewayApiGroupResponseBodyApiGroup ApiGroup { get; set; }
        public class UpdateGatewayApiGroupResponseBodyApiGroup : TeaModel {
            [NameInMap("Centers")]
            [Validation(Required=false)]
            public Dictionary<string, object> Centers { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("EnableMTLS")]
            [Validation(Required=false)]
            public bool? EnableMTLS { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("HttpsModel")]
            [Validation(Required=false)]
            public bool? HttpsModel { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstancePort")]
            [Validation(Required=false)]
            public int? InstancePort { get; set; }

            [NameInMap("RegionMode")]
            [Validation(Required=false)]
            public bool? RegionMode { get; set; }

            [NameInMap("Timeout")]
            [Validation(Required=false)]
            public int? Timeout { get; set; }

            [NameInMap("UpstreamType")]
            [Validation(Required=false)]
            public string UpstreamType { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcModel")]
            [Validation(Required=false)]
            public bool? VpcModel { get; set; }

        }

        [NameInMap("ErrorField")]
        [Validation(Required=false)]
        public string ErrorField { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
