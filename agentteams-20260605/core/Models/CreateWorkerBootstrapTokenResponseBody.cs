// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentTeams20260605.Models
{
    public class CreateWorkerBootstrapTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateWorkerBootstrapTokenResponseBodyData Data { get; set; }
        public class CreateWorkerBootstrapTokenResponseBodyData : TeaModel {
            [NameInMap("BootstrapToken")]
            [Validation(Required=false)]
            public string BootstrapToken { get; set; }

            [NameInMap("Cms")]
            [Validation(Required=false)]
            public CreateWorkerBootstrapTokenResponseBodyDataCms Cms { get; set; }
            public class CreateWorkerBootstrapTokenResponseBodyDataCms : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("LicenseKey")]
                [Validation(Required=false)]
                public string LicenseKey { get; set; }

                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("TokenFingerprint")]
            [Validation(Required=false)]
            public string TokenFingerprint { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
