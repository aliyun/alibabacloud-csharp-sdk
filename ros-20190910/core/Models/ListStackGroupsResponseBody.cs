// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack groups.</para>
        /// </summary>
        [NameInMap("StackGroups")]
        [Validation(Required=false)]
        public List<ListStackGroupsResponseBodyStackGroups> StackGroups { get; set; }
        public class ListStackGroupsResponseBodyStackGroups : TeaModel {
            /// <summary>
            /// <para>The information about automatic deployment settings.</para>
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public ListStackGroupsResponseBodyStackGroupsAutoDeployment AutoDeployment { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsAutoDeployment : TeaModel {
                /// <summary>
                /// <para>Indicates whether automatic deployment is enabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Automatic deployment is enabled. If you add a member to the folder to which the stack group belongs after automatic deployment is enabled, Resource Orchestration Service (ROS) automatically adds the stack instances in the stack group to the specified region of the member. If you delete the member from the folder, ROS automatically deletes the stack instances in the stack group from the specified region of the member.</description></item>
                /// <item><description>false: Automatic deployment is disabled. After you disable automatic deployment, the stack instances remain unchanged when you change the member in the folder.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the stacks within a member are retained when you delete the member from the folder.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only if Enabled is set to true.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My Stack Group</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the most recent successful drift detection was performed on the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The permission model of the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SELF_MANAGED</description></item>
            /// <item><description>SERVICE_MANAGED</description></item>
            /// </list>
            /// <remarks>
            /// <para>For more information about the permission models of stack groups, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>SELF_MANAGED</para>
            /// </summary>
            [NameInMap("PermissionModel")]
            [Validation(Required=false)]
            public string PermissionModel { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzawhxxcj****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The drift state of the stack group on which the most recent successful drift detection was performed.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DRIFTED: The stack group has drifted.</description></item>
            /// <item><description>NOT_CHECKED: No drift detection is performed on the stack group.</description></item>
            /// <item><description>IN_SYNC: No drifts are detected on the stack group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN_SYNC</para>
            /// </summary>
            [NameInMap("StackGroupDriftStatus")]
            [Validation(Required=false)]
            public string StackGroupDriftStatus { get; set; }

            /// <summary>
            /// <para>The ID of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
            /// </summary>
            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            /// <summary>
            /// <para>The name of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyStackGroup</para>
            /// </summary>
            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            /// <summary>
            /// <para>The state of the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ACTIVE</description></item>
            /// <item><description>DELETED</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags that are added to the stack group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListStackGroupsResponseBodyStackGroupsTags> Tags { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag that is added to the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usage1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag that is added to the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of stack groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
