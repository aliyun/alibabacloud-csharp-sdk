// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListStackResourcesResponseBodyResources> Resources { get; set; }
        public class ListStackResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T06:01:23</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the most recent successful drift detection was performed on the stack.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The logical ID of the resource. The logical ID is the resource name that is defined in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dummy</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The information about the modules from which the resource is created. This parameter is returned only if the resource is created from modules.</para>
            /// </summary>
            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourcesResponseBodyResourcesModuleInfo ModuleInfo { get; set; }
            public class ListStackResourcesResponseBodyResourcesModuleInfo : TeaModel {
                /// <summary>
                /// <para>The concatenated logical IDs of one or more modules that contain the resource. The modules are listed from the outermost layer and separated by forward slashes (<c>/</c>).</para>
                /// <para>In the following example, the resource is created from Module B nested within Parent Module A:</para>
                /// <para><c>moduleA/moduleB</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>moduleA/moduleB</para>
                /// </summary>
                [NameInMap("LogicalIdHierarchy")]
                [Validation(Required=false)]
                public string LogicalIdHierarchy { get; set; }

                /// <summary>
                /// <para>The concatenated types of one or more modules that contain the resource. The module types are listed from the outermost layer and separated by forward slashes (<c>/</c>).</para>
                /// <para>In the following example, the resource is created from a module of the <c>MODULE::ROS::Child::Example</c> type that is nested within a parent module of the <c>MODULE::ROS::Parent::Example</c> type:</para>
                /// <para><c>MODULE::ROS::Parent::Example/MODULE::ROS::Child::Example</c></para>
                /// 
                /// <b>Example:</b>
                /// <para>MODULE::ROS::Parent::Example/MODULE::ROS::Child::Example</para>
                /// </summary>
                [NameInMap("TypeHierarchy")]
                [Validation(Required=false)]
                public string TypeHierarchy { get; set; }

            }

            /// <summary>
            /// <para>The physical ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d04af923-e6b7-4272-aeaa-47ec9777****</para>
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// <para>The drift state of the resource in the most recent successful drift detection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.</description></item>
            /// <item><description>MODIFIED: The actual configuration of the resource differs from its expected template configuration.</description></item>
            /// <item><description>NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the actual configuration of the resource differs from its expected template configuration.</description></item>
            /// <item><description>IN_SYNC: The actual configuration of the resource matches its expected template configuration.</description></item>
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
            /// <para>The stack name.\
            /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-describe-resource</para>
            /// </summary>
            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            /// <summary>
            /// <para>The state of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT_COMPLETE: The resource is pending to be created.</description></item>
            /// <item><description>CREATE_COMPLETE: The resource is created.</description></item>
            /// <item><description>CREATE_FAILED: The resource failed to be created.</description></item>
            /// <item><description>CREATE_IN_PROGRESS: The resource is being created.</description></item>
            /// <item><description>UPDATE_IN_PROGRESS: The resource is being updated.</description></item>
            /// <item><description>UPDATE_FAILED: The resource failed to be updated.</description></item>
            /// <item><description>UPDATE_COMPLETE: The resource is updated.</description></item>
            /// <item><description>DELETE_IN_PROGRESS: The resource is being deleted.</description></item>
            /// <item><description>DELETE_FAILED: The resource failed to be deleted.</description></item>
            /// <item><description>DELETE_COMPLETE: The resource is deleted.</description></item>
            /// <item><description>CHECK_IN_PROGRESS: The resource is being validated.</description></item>
            /// <item><description>CHECK_FAILED: The resource failed to be validated.</description></item>
            /// <item><description>CHECK_COMPLETE: The resource is validated.</description></item>
            /// <item><description>IMPORT_IN_PROGRESS: The resource is being imported.</description></item>
            /// <item><description>IMPORT_FAILED: The resource failed to be imported.</description></item>
            /// <item><description>IMPORT_COMPLETE: The resource is imported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the resource is in its current state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>state changed</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The time when the resource was updated. The time is displayed in UTC. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format.</para>
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
