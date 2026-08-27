// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
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
            /// <para>The automatic deployment settings.</para>
            /// </summary>
            [NameInMap("AutoDeployment")]
            [Validation(Required=false)]
            public ListStackGroupsResponseBodyStackGroupsAutoDeployment AutoDeployment { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsAutoDeployment : TeaModel {
                /// <summary>
                /// <para>Whether automatic deployment is enabled.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Automatic deployment is enabled. When a member account is added to the target folder, ROS deploys a stack instance for it. When a member account is removed, ROS deletes the stack instance.</para>
                /// </description></item>
                /// <item><description><para>false: Automatic deployment is disabled. Stack instances remain unchanged when folder membership changes.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>Whether stacks are retained when member accounts are removed from the folder.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The stacks are retained.</para>
                /// </description></item>
                /// <item><description><para>false: The stacks are deleted.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Returned only when Enabled is true.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RetainStacksOnAccountRemoval")]
                [Validation(Required=false)]
                public bool? RetainStacksOnAccountRemoval { get; set; }

            }

            /// <summary>
            /// <para>The creation time of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-05T05:38:31</para>
            /// </summary>
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
            /// <para>The time of the last successful drift detection on the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The permission model.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SELF_MANAGED: self-managed permissions.</para>
            /// </description></item>
            /// <item><description><para>SERVICE_MANAGED: service-managed permissions.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>For details on permission models of stack groups, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
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
            /// <para>The drift status of the stack group from the last successful drift detection.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DRIFTED: The stack group has drifted from its template.</para>
            /// </description></item>
            /// <item><description><para>NOT_CHECKED: No drift detection has been performed.</para>
            /// </description></item>
            /// <item><description><para>IN_SYNC: The stack group matches its template.</para>
            /// </description></item>
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
            /// <para>The status of the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ACTIVE</para>
            /// </description></item>
            /// <item><description><para>DELETED</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tags of the stack group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListStackGroupsResponseBodyStackGroupsTags> Tags { get; set; }
            public class ListStackGroupsResponseBodyStackGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usage1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the stack group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The last update time of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-15T16:40:25</para>
            /// </summary>
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
