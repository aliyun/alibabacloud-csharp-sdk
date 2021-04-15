// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListEurekaInstancesResponseBody : TeaModel {
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEurekaInstancesResponseBodyData> Data { get; set; }
        public class ListEurekaInstancesResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("LastDirtyTimestamp")]
            [Validation(Required=false)]
            public long? LastDirtyTimestamp { get; set; }

            [NameInMap("IpAddr")]
            [Validation(Required=false)]
            public string IpAddr { get; set; }

            [NameInMap("HomePageUrl")]
            [Validation(Required=false)]
            public string HomePageUrl { get; set; }

            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("SecurePort")]
            [Validation(Required=false)]
            public int? SecurePort { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("DurationInSecs")]
            [Validation(Required=false)]
            public int? DurationInSecs { get; set; }

            [NameInMap("LastUpdatedTimestamp")]
            [Validation(Required=false)]
            public long? LastUpdatedTimestamp { get; set; }

            [NameInMap("RenewalIntervalInSecs")]
            [Validation(Required=false)]
            public int? RenewalIntervalInSecs { get; set; }

            [NameInMap("VipAddress")]
            [Validation(Required=false)]
            public string VipAddress { get; set; }

            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
