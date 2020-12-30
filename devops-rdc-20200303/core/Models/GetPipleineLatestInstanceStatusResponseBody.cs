// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipleineLatestInstanceStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetPipleineLatestInstanceStatusResponseBodyObject Object { get; set; }
        public class GetPipleineLatestInstanceStatusResponseBodyObject : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetPipleineLatestInstanceStatusResponseBodyObjectGroups> Groups { get; set; }
            public class GetPipleineLatestInstanceStatusResponseBodyObjectGroups : TeaModel {
                public string Status { get; set; }
                public List<GetPipleineLatestInstanceStatusResponseBodyObjectGroupsStages> Stages { get; set; }
                public class GetPipleineLatestInstanceStatusResponseBodyObjectGroupsStages : TeaModel {
                    public string Status { get; set; }
                    public string Sign { get; set; }
                    public List<GetPipleineLatestInstanceStatusResponseBodyObjectGroupsStagesComponents> Components { get; set; }
                    public class GetPipleineLatestInstanceStatusResponseBodyObjectGroupsStagesComponents : TeaModel {
                        public string Status { get; set; }
                        public long? JobId { get; set; }
                        public string Name { get; set; }
                    }
                }
                public string Name { get; set; }
            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
