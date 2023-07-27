// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetAccessPointResult : TeaModel {
        [NameInMap("AccessPointArn")]
        [Validation(Required=false)]
        public string AccessPointArn { get; set; }

        [NameInMap("AccessPointName")]
        [Validation(Required=false)]
        public string AccessPointName { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public GetAccessPointResultEndpoints Endpoints { get; set; }
        public class GetAccessPointResultEndpoints : TeaModel {
            [NameInMap("PublicEndpoint")]
            [Validation(Required=false)]
            public string PublicEndpoint { get; set; }

        }

        [NameInMap("InternalEndpoint")]
        [Validation(Required=false)]
        public string InternalEndpoint { get; set; }

        [NameInMap("NetworkOrigin")]
        [Validation(Required=false)]
        public string NetworkOrigin { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VpcConfiguration")]
        [Validation(Required=false)]
        public AccessPointVpcConfiguration VpcConfiguration { get; set; }

    }

}
