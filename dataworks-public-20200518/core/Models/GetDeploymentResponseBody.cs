// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDeploymentResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeploymentResponseBodyData Data { get; set; }
        public class GetDeploymentResponseBodyData : TeaModel {
            [NameInMap("DeployedItems")]
            [Validation(Required=false)]
            public List<GetDeploymentResponseBodyDataDeployedItems> DeployedItems { get; set; }
            public class GetDeploymentResponseBodyDataDeployedItems : TeaModel {
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public long? FileVersion { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("Deployment")]
            [Validation(Required=false)]
            public GetDeploymentResponseBodyDataDeployment Deployment { get; set; }
            public class GetDeploymentResponseBodyDataDeployment : TeaModel {
                [NameInMap("CheckingStatus")]
                [Validation(Required=false)]
                public int? CheckingStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                [NameInMap("FromEnvironment")]
                [Validation(Required=false)]
                public int? FromEnvironment { get; set; }

                [NameInMap("HandlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("ToEnvironment")]
                [Validation(Required=false)]
                public int? ToEnvironment { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
