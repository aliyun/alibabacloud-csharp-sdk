// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class GetAllowedIpListResponseBody : TeaModel {
        [NameInMap("AllowedList")]
        [Validation(Required=false)]
        public GetAllowedIpListResponseBodyAllowedList AllowedList { get; set; }
        public class GetAllowedIpListResponseBodyAllowedList : TeaModel {
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public int? DeployType { get; set; }

            [NameInMap("InternetList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListInternetList> InternetList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListInternetList : TeaModel {
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

            }

            [NameInMap("VpcList")]
            [Validation(Required=false)]
            public List<GetAllowedIpListResponseBodyAllowedListVpcList> VpcList { get; set; }
            public class GetAllowedIpListResponseBodyAllowedListVpcList : TeaModel {
                [NameInMap("AllowedIpList")]
                [Validation(Required=false)]
                public List<string> AllowedIpList { get; set; }

                [NameInMap("PortRange")]
                [Validation(Required=false)]
                public string PortRange { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

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
