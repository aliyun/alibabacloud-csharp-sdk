// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsInstanceBaseInfoResponseBody : TeaModel {
        [NameInMap("InstanceBaseInfo")]
        [Validation(Required=false)]
        public OnsInstanceBaseInfoResponseBodyInstanceBaseInfo InstanceBaseInfo { get; set; }
        public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfo : TeaModel {
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints Endpoints { get; set; }
            public class OnsInstanceBaseInfoResponseBodyInstanceBaseInfoEndpoints : TeaModel {
                [NameInMap("TcpEndpoint")]
                [Validation(Required=false)]
                public string TcpEndpoint { get; set; }

                [NameInMap("HttpInternetEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetEndpoint { get; set; }

                [NameInMap("HttpInternalEndpoint")]
                [Validation(Required=false)]
                public string HttpInternalEndpoint { get; set; }

                [NameInMap("HttpInternetSecureEndpoint")]
                [Validation(Required=false)]
                public string HttpInternetSecureEndpoint { get; set; }

            }
            [NameInMap("IndependentNaming")]
            [Validation(Required=false)]
            public bool? IndependentNaming { get; set; }
            [NameInMap("MaxTps")]
            [Validation(Required=false)]
            public long? MaxTps { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }
            [NameInMap("TopicCapacity")]
            [Validation(Required=false)]
            public int? TopicCapacity { get; set; }
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public int? InstanceStatus { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public int? InstanceType { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
