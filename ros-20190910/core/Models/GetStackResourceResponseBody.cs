// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-01T06:01:23</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The reason why the resource is in its current state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-27T07:47:47</para>
        /// </summary>
        [NameInMap("DriftDetectionTime")]
        [Validation(Required=false)]
        public string DriftDetectionTime { get; set; }

        /// <summary>
        /// <para>The time when the resource was updated.</para>
        /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

        /// <summary>
        /// <para>The list of the resource properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The information about the modules from which the resource is created. This parameter is returned only if the resource is created from modules.</para>
        /// </summary>
        [NameInMap("ModuleInfo")]
        [Validation(Required=false)]
        public GetStackResourceResponseBodyModuleInfo ModuleInfo { get; set; }
        public class GetStackResourceResponseBodyModuleInfo : TeaModel {
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
        /// <para>The metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d04af923-e6b7-4272-aeaa-47ec9777****</para>
        /// </summary>
        [NameInMap("PhysicalResourceId")]
        [Validation(Required=false)]
        public string PhysicalResourceId { get; set; }

        /// <summary>
        /// <para>The physical ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the resource in the last successful drift detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.</description></item>
        /// <item><description>MODIFIED: The actual configuration of the resource differs from its expected template configuration.</description></item>
        /// <item><description>NOT_CHECKED: ROS has not checked whether the actual configuration of the resource differs from its expected template configuration.</description></item>
        /// <item><description>IN_SYNC: The actual configuration of the resource matches its expected template configuration.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceAttributes")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> ResourceAttributes { get; set; }

        /// <summary>
        /// <para>The time when the last successful drift detection was performed on the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IN_SYNC</para>
        /// </summary>
        [NameInMap("ResourceDriftStatus")]
        [Validation(Required=false)]
        public string ResourceDriftStatus { get; set; }

        /// <summary>
        /// <para>The logical ID of the resource defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ROS::WaitConditionHandle</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efdf5c10-96a5-4fd7-ab89-68e7baa2****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The name of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-describe-resource</para>
        /// </summary>
        [NameInMap("StackName")]
        [Validation(Required=false)]
        public string StackName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE_COMPLETE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the resource was created.</para>
        /// <para>The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>state changed</para>
        /// </summary>
        [NameInMap("StatusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        /// <summary>
        /// <para>The name of the stack.</para>
        /// <para>The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). The name must start with a digit or letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-01T06:01:29</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
