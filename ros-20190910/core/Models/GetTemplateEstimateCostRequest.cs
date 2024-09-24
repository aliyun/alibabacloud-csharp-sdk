// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateEstimateCostRequest : TeaModel {
        /// <summary>
        /// <para>The name of parameter N. If you do not specify the name and value of a parameter, ROS uses the default name and value that are specified in the template.</para>
        /// <para>Maximum value of N: 200.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Parameters.1.ParameterKey: <c>Name</c></description></item>
        /// <item><description>Parameters.2.ParameterKey: <c>Netmode</c></description></item>
        /// </list>
        /// <remarks>
        /// <para> The Parameters parameter is optional. If you want to specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the scenario. The default value is the same as the value of the RegionId parameter.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetTemplateEstimateCostRequestParameters> Parameters { get; set; }
        public class GetTemplateEstimateCostRequestParameters : TeaModel {
            /// <summary>
            /// <para>The ID of the request.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>Details of the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoEip</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// <para>This parameter is used to query the estimated price in a configuration change scenario.</para>
        /// <para>Assume that the specified stack contains only one Elastic Compute Service (ECS) instance and the instance type is ecs.s6-c1m2.large. You downgrade the instance type to ecs.s6-c1m1.small and specify a new ApsaraDB RDS instance in the template that is used for the price inquiry. The queried result is the sum of the downgrade refund of the ECS instance and the price of the new ApsaraDB RDS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c754d2a4-28f1-46df-b557-9586173a****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The value of parameter N.</para>
        /// <para>Maximum value of N: 200.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>Parameters.1.ParameterValue: <c>DemoEip</c></description></item>
        /// <item><description>Parameters.2.ParameterValue: <c>public</c></description></item>
        /// </list>
        /// <remarks>
        /// <para> The Parameters parameter is optional. If you want to specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-aa9c62feab844a6b****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The region ID of the scenario. The default value is the same as the value of the RegionId parameter.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("TemplateScratchRegionId")]
        [Validation(Required=false)]
        public string TemplateScratchRegionId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests.</para>
        /// <para>The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The ID of the scenario.</para>
        /// <para>For more information about how to query the IDs of scenarios, see <a href="https://help.aliyun.com/document_detail/363050.html">ListTemplateScratches</a>.</para>
        /// <remarks>
        /// <para> You must specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
