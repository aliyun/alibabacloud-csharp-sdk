// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRouteProtocolOspfResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeadTime")]
        [Validation(Required=false)]
        public int? DeadTime { get; set; }

        [NameInMap("Md5KeyId")]
        [Validation(Required=false)]
        public int? Md5KeyId { get; set; }

        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public string AreaId { get; set; }

        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        [NameInMap("HelloTime")]
        [Validation(Required=false)]
        public int? HelloTime { get; set; }

        [NameInMap("AreaType")]
        [Validation(Required=false)]
        public string AreaType { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagRouteProtocolOspfResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagRouteProtocolOspfResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

        [NameInMap("Md5Key")]
        [Validation(Required=false)]
        public string Md5Key { get; set; }

        [NameInMap("AuthenticationType")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

    }

}
