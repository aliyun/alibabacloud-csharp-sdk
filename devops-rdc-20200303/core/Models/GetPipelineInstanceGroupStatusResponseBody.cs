// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops_rdc20200303.Models
{
    public class GetPipelineInstanceGroupStatusResponseBody : TeaModel {
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
        public GetPipelineInstanceGroupStatusResponseBodyObject Object { get; set; }
        public class GetPipelineInstanceGroupStatusResponseBodyObject : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<GetPipelineInstanceGroupStatusResponseBodyObjectGroups> Groups { get; set; }
            public class GetPipelineInstanceGroupStatusResponseBodyObjectGroups : TeaModel {
                public string Status { get; set; }
                public string Name { get; set; }
                public List<GetPipelineInstanceGroupStatusResponseBodyObjectGroupsStages> Stages { get; set; }
                public class GetPipelineInstanceGroupStatusResponseBodyObjectGroupsStages : TeaModel {
                    public string Status { get; set; }
                    public string Sign { get; set; }
                    public List<GetPipelineInstanceGroupStatusResponseBodyObjectGroupsStagesComponents> Components { get; set; }
                    public class GetPipelineInstanceGroupStatusResponseBodyObjectGroupsStagesComponents : TeaModel {
                        public string Status { get; set; }
                        public string Name { get; set; }
                        public string JobId { get; set; }
                    }
                }
            }
        };

    }

}
