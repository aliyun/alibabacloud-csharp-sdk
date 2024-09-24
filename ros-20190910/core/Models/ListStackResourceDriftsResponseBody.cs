// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackResourceDriftsResponseBody : TeaModel {
        /// <summary>
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****w==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource drifts.</para>
        /// </summary>
        [NameInMap("ResourceDrifts")]
        [Validation(Required=false)]
        public List<ListStackResourceDriftsResponseBodyResourceDrifts> ResourceDrifts { get; set; }
        public class ListStackResourceDriftsResponseBodyResourceDrifts : TeaModel {
            /// <summary>
            /// <para>The actual JSON-formatted resource properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ScalingRuleName&quot;: &quot;test1&quot;}</para>
            /// </summary>
            [NameInMap("ActualProperties")]
            [Validation(Required=false)]
            public string ActualProperties { get; set; }

            /// <summary>
            /// <para>The time when the drift detection operation was performed on the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-02-27T07:47:47</para>
            /// </summary>
            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            /// <summary>
            /// <para>The JSON-formatted resource properties that are defined in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ScalingRuleName&quot;: &quot;test2&quot;}</para>
            /// </summary>
            [NameInMap("ExpectedProperties")]
            [Validation(Required=false)]
            public string ExpectedProperties { get; set; }

            /// <summary>
            /// <para>The logical ID of the resource. The logical ID indicates the name of the resource that is defined in the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScalingRule</para>
            /// </summary>
            [NameInMap("LogicalResourceId")]
            [Validation(Required=false)]
            public string LogicalResourceId { get; set; }

            /// <summary>
            /// <para>The information about the modules from which the resource was created. This parameter is returned only if the resource is created from modules.</para>
            /// </summary>
            [NameInMap("ModuleInfo")]
            [Validation(Required=false)]
            public ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo ModuleInfo { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsModuleInfo : TeaModel {
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
            /// <para>asr-2ze4zzc3kf9yz1kd****</para>
            /// </summary>
            [NameInMap("PhysicalResourceId")]
            [Validation(Required=false)]
            public string PhysicalResourceId { get; set; }

            /// <summary>
            /// <para>The property drifts of the resource.</para>
            /// </summary>
            [NameInMap("PropertyDifferences")]
            [Validation(Required=false)]
            public List<ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences> PropertyDifferences { get; set; }
            public class ListStackResourceDriftsResponseBodyResourceDriftsPropertyDifferences : TeaModel {
                /// <summary>
                /// <para>The actual value of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("ActualValue")]
                [Validation(Required=false)]
                public string ActualValue { get; set; }

                /// <summary>
                /// <para>The drift type of the resource property. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ADD: The value is added to a resource property whose data type is Array or List.</description></item>
                /// <item><description>REMOVE: The property is deleted from the current resource configuration.</description></item>
                /// <item><description>NOT_EQUAL: The current property value differs from the expected value that is defined in the stack template.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NOT_EQUAL</para>
                /// </summary>
                [NameInMap("DifferenceType")]
                [Validation(Required=false)]
                public string DifferenceType { get; set; }

                /// <summary>
                /// <para>The expected value of the resource property that is defined in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
                /// </summary>
                [NameInMap("ExpectedValue")]
                [Validation(Required=false)]
                public string ExpectedValue { get; set; }

                /// <summary>
                /// <para>The path of the resource property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/ScalingRuleName</para>
                /// </summary>
                [NameInMap("PropertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

            }

            /// <summary>
            /// <para>The drift state of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DELETED: The actual configuration of the resource differs from its expected template configuration because the resource is deleted.</description></item>
            /// <item><description>MODIFIED: The actual configuration of the resource differs from its expected template configuration.</description></item>
            /// <item><description>NOT_CHECKED: Resource Orchestration Service (ROS) has not checked whether the actual configuration of the resource differs from its expected template configuration.</description></item>
            /// <item><description>IN_SYNC: The actual configuration of the resource matches its expected template configuration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MODIFIED</para>
            /// </summary>
            [NameInMap("ResourceDriftStatus")]
            [Validation(Required=false)]
            public string ResourceDriftStatus { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN::ESS::ScalingRule</para>
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

        }

    }

}
