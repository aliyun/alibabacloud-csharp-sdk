// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackInstancesResponseBody : TeaModel {
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85DE34BD-7FF9-480F-8C21-556E9DA93ACD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stacks.</para>
        /// </summary>
        [NameInMap("StackInstances")]
        [Validation(Required=false)]
        public List<ListStackInstancesResponseBodyStackInstances> StackInstances { get; set; }
        public class ListStackInstancesResponseBodyStackInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the destination account to which the stack belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>156552876021****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the last successful drift detection was performed on the stack.</para>
            /// <remarks>
            /// <para>This parameter is returned only if drift detection is performed on the stack group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The ID of the folder in the resource directory.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the stack group is granted service-managed permissions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fd-4PvlVLOL8v</para>
            /// </summary>
            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }

            /// <summary>
            /// <para>The region ID of the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The state of the stack when the last successful drift detection was performed on the stack group.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DRIFTED: The stack has drifted.</description></item>
            /// <item><description>NOT_CHECKED: No successful drift detection is performed on the stack.</description></item>
            /// <item><description>IN_SYNC: The stack is being synchronized.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only if drift detection is performed on the stack group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IN_SYNC</para>
            /// </summary>
            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

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
            /// <para>The stack ID.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the stack is in the CURRENT state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>35ad60e3-6a92-42d8-8812-f0700d45****</para>
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The state of the stack.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CURRENT: The stack is up-to-date with the stack group.</para>
            /// </description></item>
            /// <item><description><para>OUTDATED: The stack is not up-to-date with the stack group. Stacks are in the OUTDATED state due to the following possible reasons:</para>
            /// <list type="bullet">
            /// <item><description>When the CreateStackInstances operation is called to create stacks, the stacks fail to be created.</description></item>
            /// <item><description>When the UpdateStackInstances or UpdateStackGroup operation is called to update stacks, the stacks fail to be updated, or only specific stacks are updated.</description></item>
            /// <item><description>The creation or update operation is not complete.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CURRENT</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the stack instance is in the OUTDATED state.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the stack instance is in the OUTDATED state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>User initiated stop</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// <para>The total number of stacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
