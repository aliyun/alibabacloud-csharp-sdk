// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public List<GetPipelineLogResponseBodyObject> Object { get; set; }
        public class GetPipelineLogResponseBodyObject : TeaModel {
            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            [NameInMap("BuildProcessNodes")]
            [Validation(Required=false)]
            public List<GetPipelineLogResponseBodyObjectBuildProcessNodes> BuildProcessNodes { get; set; }
            public class GetPipelineLogResponseBodyObjectBuildProcessNodes : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("NodeIndex")]
                [Validation(Required=false)]
                public int? NodeIndex { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

        }

    }

}
