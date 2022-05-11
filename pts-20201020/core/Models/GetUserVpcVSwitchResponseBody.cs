// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetUserVpcVSwitchResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VSwitchCount")]
        [Validation(Required=false)]
        public int? VSwitchCount { get; set; }

        [NameInMap("VSwitchList")]
        [Validation(Required=false)]
        public List<GetUserVpcVSwitchResponseBodyVSwitchList> VSwitchList { get; set; }
        public class GetUserVpcVSwitchResponseBodyVSwitchList : TeaModel {
            [NameInMap("AvailableIpAddressCount")]
            [Validation(Required=false)]
            public long? AvailableIpAddressCount { get; set; }

            [NameInMap("MaxAgentCount")]
            [Validation(Required=false)]
            public int? MaxAgentCount { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
