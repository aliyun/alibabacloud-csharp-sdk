// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowNodeInstanceContainerStatusResponseBody : TeaModel {
        [NameInMap("ContainerStatusList")]
        [Validation(Required=false)]
        public ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusList ContainerStatusList { get; set; }
        public class ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusList : TeaModel {
            [NameInMap("ContainerStatus")]
            [Validation(Required=false)]
            public List<ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusListContainerStatus> ContainerStatus { get; set; }
            public class ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusListContainerStatus : TeaModel {
                /// <summary>
                /// Application ID。
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// Container ID。
                /// </summary>
                [NameInMap("ContainerId")]
                [Validation(Required=false)]
                public string ContainerId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
