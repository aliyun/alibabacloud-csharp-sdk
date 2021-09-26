// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class ListFlowNodeInstanceContainerStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("ContainerStatusList")]
        [Validation(Required=false)]
        public ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusList ContainerStatusList { get; set; }
        public class ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusList : TeaModel {
            [NameInMap("ContainerStatus")]
            [Validation(Required=false)]
            public List<ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusListContainerStatus> ContainerStatus { get; set; }
            public class ListFlowNodeInstanceContainerStatusResponseBodyContainerStatusListContainerStatus : TeaModel {
                public string Status { get; set; }
                public string HostName { get; set; }
                public string ContainerId { get; set; }
                public string ApplicationId { get; set; }
            }
        };

    }

}
