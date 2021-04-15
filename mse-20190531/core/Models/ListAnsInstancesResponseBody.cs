// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAnsInstancesResponseBody : TeaModel {
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
        public List<ListAnsInstancesResponseBodyData> Data { get; set; }
        public class ListAnsInstancesResponseBodyData : TeaModel {
            [NameInMap("DefaultKey")]
            [Validation(Required=false)]
            public string DefaultKey { get; set; }

            [NameInMap("Ephemeral")]
            [Validation(Required=false)]
            public bool? Ephemeral { get; set; }

            [NameInMap("Marked")]
            [Validation(Required=false)]
            public bool? Marked { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("LastBeat")]
            [Validation(Required=false)]
            public long? LastBeat { get; set; }

            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

            [NameInMap("InstanceHeartBeatInterval")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatInterval { get; set; }

            [NameInMap("IpDeleteTimeout")]
            [Validation(Required=false)]
            public int? IpDeleteTimeout { get; set; }

            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("Healthy")]
            [Validation(Required=false)]
            public bool? Healthy { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("DatumKey")]
            [Validation(Required=false)]
            public string DatumKey { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("InstanceHeartBeatTimeOut")]
            [Validation(Required=false)]
            public int? InstanceHeartBeatTimeOut { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

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
