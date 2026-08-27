// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the resource was created. The time is displayed in UTC+0 and in the ISO 8601 standard format without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-01T06:01:23</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The resource description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the resource was last successfully checked for drift detection of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-27T07:47:47</para>
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// <para>The logical ID of the resource, which is the resource name defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// <para>The metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The information about the module from which the resource was created. This parameter is returned only when the resource is created from a module.</para>
        /// </summary>
        [NameInMap("ModuleInfo")]
        [Validation(Required=false)]
        public GetStackResourceResponseBodyModuleInfo ModuleInfo { get; set; }
        public class GetStackResourceResponseBodyModuleInfo : TeaModel {
            /// <summary>
            /// <para>A concatenated list of the logical IDs of one or more modules that contain the resource. The modules are listed starting from the outermost module, separated by <c>/</c>.</para>
            /// <para>In the following example, the resource was created from moduleB, which is nested in the parent module moduleA.</para>
            /// <para><c>moduleA/moduleB</c></para>
            /// 
            /// <b>Example:</b>
            /// <para>moduleA/moduleB</para>
            /// </summary>
            [NameInMap("LogicalIdHierarchy")]
            [Validation(Required=false)]
            public string LogicalIdHierarchy { get; set; }

            /// <summary>
            /// <para>A concatenated list of the types of one or more modules that contain the resource. The module types are listed starting from the outermost module, separated by <c>/</c>.</para>
            /// <para>In the following example, the resource was created from a module of the <c>MODULE::ROS::Child::Example</c> type, which is nested in a parent module of the <c>MODULE::ROS::Parent::Example</c> type.</para>
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
        /// <para>The physical ID of the resource, which is the actual resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d04af923-e6b7-4272-aeaa-47ec9777****</para>
        /// </summary>
        [NameInMap("PhysicalResourceId")]
        [Validation(Required=false)]
        public string PhysicalResourceId { get; set; }

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
        /// <para>The resource attribute list.</para>
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ResourceAttributes { get; set; }

        /// <summary>
        /// <para>The drift status of the resource in the most recent successful drift detection of the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DELETED: The resource differs from its expected template configuration because the resource has been deleted.</description></item>
        /// <item><description>MODIFIED: The resource differs from its expected template configuration.</description></item>
        /// <item><description>NOT_CHECKED: ROS has not checked whether the resource differs from its expected template configuration.</description></item>
        /// <item><description>IN_SYNC: The current configuration of the resource matches its expected template configuration.</description></item>
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
        /// <para>ALIYUN::ROS::WaitConditionHandle</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efdf5c10-96a5-4fd7-ab89-68e7baa2****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The stack name.
        /// The name can be up to 255 characters in length, and must start with a digit or letter. It can contain digits, letters, hyphens (-), and underscores (_).</para>
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
        /// <item><description>CREATE_COMPLETE</description></item>
        /// <item><description>CREATE_FAILED</description></item>
        /// <item><description>CREATE_IN_PROGRESS</description></item>
        /// <item><description>UPDATE_IN_PROGRESS</description></item>
        /// <item><description>UPDATE_FAILED</description></item>
        /// <item><description>UPDATE_COMPLETE</description></item>
        /// <item><description>DELETE_IN_PROGRESS</description></item>
        /// <item><description>DELETE_FAILED</description></item>
        /// <item><description>CHECK_IN_PROGRESS</description></item>
        /// <item><description>CHECK_FAILED</description></item>
        /// <item><description>CHECK_COMPLETE</description></item>
        /// <item><description>IMPORT_IN_PROGRESS</description></item>
        /// <item><description>IMPORT_FAILED</description></item>
        /// <item><description>IMPORT_COMPLETE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The reason why the resource is in the current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>state changed</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The time when the resource was last updated. The time is displayed in UTC+0 and in the ISO 8601 standard format without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-01T06:01:29</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
