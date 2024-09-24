// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DetectStackResourceDriftResponseBody : TeaModel {
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
        /// <para>The time when the resource drift detection was initiated.</para>
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
        /// <para>The logical ID of the resource that is defined in the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ScalingRule</para>
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public string LogicalResourceId { get; set; }

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
        public List<DetectStackResourceDriftResponseBodyPropertyDifferences> PropertyDifferences { get; set; }
        public class DetectStackResourceDriftResponseBodyPropertyDifferences : TeaModel {
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
            /// <item><description>ADD: The property value has been added to a resource property whose data type was Array or List.</description></item>
            /// <item><description>REMOVE: The property has been deleted from the current resource configuration.</description></item>
            /// <item><description>NOT_EQUAL: The current property value differs from the expected value defined in the stack template.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The drift status of the resource. Valid values:</para>
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
        /// <para>The type of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::ESS::ScalingRule</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
