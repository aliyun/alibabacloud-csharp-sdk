// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resource objects.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListStackResourcesResponseBodyResources> Resources { get; set; }
        public class ListStackResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC+0 and follows the ISO 8601 standard. The time is in the YYYY-MM-DDThh:mm:ss format without the Z suffix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T06:01:23</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the resource drift was detected during the most recent successful drift detection on the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The logical resource ID, which is the name defined in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dummy</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The information about the module from which the resource is created. This parameter is returned only if the resource is created from a module.</para>
            /// </summary>
            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourcesResponseBodyResourcesModuleInfo ModuleInfo { get; set; }
            public class ListStackResourcesResponseBodyResourcesModuleInfo : TeaModel {
                /// <summary>
                /// <para>The concatenated list of logical IDs of one or more modules that contain the resource. The modules are listed starting from the outermost module and are separated by <c>/</c>.</para>
                /// <para>In the following example, the resource is created from a module moduleB that is nested in a parent module moduleA.</para>
                /// <para><c>moduleA/moduleB</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>moduleA/moduleB</para>
                /// </summary>
                [NameInMap("LogicalIdHierarchy")]
                [Validation(Required=false)]
                public string LogicalIdHierarchy { get; set; }

                /// <summary>
                /// <para>The concatenated list of module types of one or more modules that contain the resource. The module types are listed starting from the outermost module and are separated by <c>/</c>.</para>
                /// <para>In the following example, the resource is created from a module of the <c>MODULE::ROS::Child::Example</c> type, which is nested in a parent module of the <c>MODULE::ROS::Parent::Example</c> type.</para>
                /// <para><c>MODULE::ROS::Parent::Example/MODULE::ROS::Child::Example</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MODULE::ROS::Parent::Example/MODULE::ROS::Child::Example</para>
                /// </summary>
                [NameInMap("TypeHierarchy")]
                [Validation(Required=false)]
                public string TypeHierarchy { get; set; }

            }

            /// <summary>
            /// <para>The physical resource ID, which is the actual resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d04af923-e6b7-4272-aeaa-47ec9777****</para>
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// <para>The drift status of the resource in the most recent successful drift detection on the stack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DELETED: The resource differs from the expected template configuration because the resource is deleted.</description></item>
            /// <item><description>MODIFIED: The resource differs from the expected template configuration.</description></item>
            /// <item><description>NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the resource differs from the expected template configuration.</description></item>
            /// <item><description>IN_SYNC: The current configuration of the resource matches the expected template configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN_SYNC</para>
            /// </summary>
            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ROS::Stack</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The stack ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
            /// </summary>
            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <para>The stack name. The name can be up to 255 characters in length and must start with a digit or a letter. It can contain digits, letters, hyphens (-), and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-describe-resource</para>
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The resource status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>INIT_COMPLETE: The resource is pending creation.</para>
            /// </description></item>
            /// <item><description><para>CREATE_COMPLETE: The resource is created.</para>
            /// </description></item>
            /// <item><description><para>CREATE_FAILED: The resource failed to be created.</para>
            /// </description></item>
            /// <item><description><para>CREATE_IN_PROGRESS: The resource is being created.</para>
            /// </description></item>
            /// <item><description><para>UPDATE_IN_PROGRESS: The resource is being updated.</para>
            /// </description></item>
            /// <item><description><para>UPDATE_FAILED: The resource failed to be updated.</para>
            /// </description></item>
            /// <item><description><para>UPDATE_COMPLETE: The resource is updated.</para>
            /// </description></item>
            /// <item><description><para>DELETE_IN_PROGRESS: The resource is being deleted.</para>
            /// </description></item>
            /// <item><description><para>DELETE_FAILED: The resource failed to be deleted.</para>
            /// </description></item>
            /// <item><description><para>DELETE_COMPLETE: The resource is deleted.</para>
            /// </description></item>
            /// <item><description><para>CHECK_IN_PROGRESS: The resource is being checked.</para>
            /// </description></item>
            /// <item><description><para>CHECK_FAILED: The resource failed to be checked.</para>
            /// </description></item>
            /// <item><description><para>CHECK_COMPLETE: The resource is checked.</para>
            /// </description></item>
            /// <item><description><para>IMPORT_IN_PROGRESS: The resource import is in progress.</para>
            /// </description></item>
            /// <item><description><para>IMPORT_FAILED: The resource import failed.</para>
            /// </description></item>
            /// <item><description><para>IMPORT_COMPLETE: The resource import is complete.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for the resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>state changed</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The time when the resource was last updated. The time is displayed in UTC+0 and follows the ISO 8601 standard. The time is in the YYYY-MM-DDThh:mm:ss format without the Z suffix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T06:01:29</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
