// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateMigrationTaskResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateMigrationTaskResponseBodyData Data { get; set; }
        public class UpdateMigrationTaskResponseBodyData : TeaModel {
            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("OriginInstanceAddress")]
            [Validation(Required=false)]
            public string OriginInstanceAddress { get; set; }

            [NameInMap("OriginInstanceName")]
            [Validation(Required=false)]
            public string OriginInstanceName { get; set; }

            [NameInMap("OriginInstanceNamespace")]
            [Validation(Required=false)]
            public string OriginInstanceNamespace { get; set; }

            [NameInMap("ProjectDesc")]
            [Validation(Required=false)]
            public string ProjectDesc { get; set; }

            [NameInMap("TargetClusterName")]
            [Validation(Required=false)]
            public string TargetClusterName { get; set; }

            [NameInMap("TargetClusterUrl")]
            [Validation(Required=false)]
            public string TargetClusterUrl { get; set; }

            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

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
