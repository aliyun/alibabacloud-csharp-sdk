// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetInstanceVpcEndpointResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

        [NameInMap("LinkedVpcs")]
        [Validation(Required=false)]
        public List<GetInstanceVpcEndpointResponseBodyLinkedVpcs> LinkedVpcs { get; set; }
        public class GetInstanceVpcEndpointResponseBodyLinkedVpcs : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("DefaultAccess")]
            [Validation(Required=false)]
            public bool? DefaultAccess { get; set; }

            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

    }

}
