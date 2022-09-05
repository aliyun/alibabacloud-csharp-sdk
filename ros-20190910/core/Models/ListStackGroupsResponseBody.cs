// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StackGroups")]
        [Validation(Required=false)]
        public List<ListStackGroupsResponseBodyStackGroups> StackGroups { get; set; }
        public class ListStackGroupsResponseBodyStackGroups : TeaModel {
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public ListStackGroupsResponseBodyStackGroupsAutoDeployment AutoDeployment { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsAutoDeployment : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("StackGroupDriftStatus")]
            [Validation(Required=false)]
            public string StackGroupDriftStatus { get; set; }

            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
