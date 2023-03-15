// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of stack groups.
        /// </summary>
        [NameInMap("StackGroups")]
        [Validation(Required=false)]
        public List<ListStackGroupsResponseBodyStackGroups> StackGroups { get; set; }
        public class ListStackGroupsResponseBodyStackGroups : TeaModel {
            /// <summary>
            /// The information about automatic deployment settings.
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public ListStackGroupsResponseBodyStackGroupsAutoDeployment AutoDeployment { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsAutoDeployment : TeaModel {
                /// <summary>
                /// Indicates whether automatic deployment is enabled.
                /// 
                /// Valid values:
                /// 
                /// *   true: Automatic deployment is enabled. If you add a member to the folder to which the stack group belongs after you enable automatic deployment, ROS automatically adds the stacks in the stack group to the specified region of the member. If you delete the member from the folder, ROS automatically deletes the stacks in the stack group from the specified region of the member.
                /// *   false: Automatic deployment is disabled. After you disable automatic deployment, the stacks remain unchanged when you change the member in the folder.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// Indicates whether the stacks within a member are retained when you delete the member from the folder.
                /// 
                /// Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// >  This parameter is returned only if the Enabled parameter is set to true.
                /// </summary>
                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            /// <summary>
            /// The description of the stack group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the last successful drift detection was performed on the stack group.
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// The permission model.
            /// 
            /// Valid values:
            /// 
            /// *   SELF_MANAGED: self-managed permission model
            /// *   SERVICE_MANAGED: service-managed permission model
            /// 
            /// >  For more information about the permission models of stack groups, see [Overview](~~154578~~).
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The state of the stack group on which the last successful drift detection was performed.
            /// 
            /// Valid values:
            /// 
            /// *   DRIFTED: The stack group has drifted.
            /// *   NOT_CHECKED: No drift detection is performed on the stack group.
            /// *   IN_SYNC: No drifts are detected on the stack group.
            /// </summary>
            [NameInMap("StackGroupDriftStatus")]
            [Validation(Required=false)]
            public string StackGroupDriftStatus { get; set; }

            /// <summary>
            /// The ID of the stack group.
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// The name of the stack group.
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// The state of the stack group.
            /// 
            /// Valid values:
            /// 
            /// *   ACTIVE
            /// *   DELETED
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags that are added to the stack group.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListStackGroupsResponseBodyStackGroupsTags> Tags { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsTags : TeaModel {
                /// <summary>
                /// The key of the tag that is added to the stack group.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag that is added to the stack group.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The total number of stack groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
