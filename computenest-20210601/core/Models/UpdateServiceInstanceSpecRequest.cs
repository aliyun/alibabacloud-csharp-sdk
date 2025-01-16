// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class UpdateServiceInstanceSpecRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information about the order placed in Alibaba Cloud Marketplace. You do not need to specify this parameter if the service is not published in Alibaba Cloud Marketplace or uses the pay-as-you-go billing method.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public UpdateServiceInstanceSpecRequestCommodity Commodity { get; set; }
        public class UpdateServiceInstanceSpecRequestCommodity : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic payment.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true (default)</b>: automatically completes the payment. You must make sure that your account balance is sufficient.</description></item>
            /// <item><description><b>false</b>: does not automatically complete the payment. An unpaid order is generated. If your account balance is insufficient, you can set AutoPay to false. In this case, an unpaid order is generated. You can complete the payment in the Expenses and Costs console.<a href="https://rdsnext.console.aliyun.com/dashboard/cn-beijing"></a></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. A dry run includes checks on the permissions and instance state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run but does not create a service instance.</description></item>
        /// <item><description>false: performs a dry run and creates a service instance if the request passes the dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus monitoring on the user side.</para>
        /// <para>Valid values:</para>
        /// <para>true</para>
        /// <para>false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// <para>The name of the configuration change operation.</para>
        /// <para>To obtain the names and content of the configuration change operations of the service, you can call the <a href="https://help.aliyun.com/document_detail/2340828.html">GetService</a> operation. In the response, check the value of <b>ModifyParametersConfig</b> in the value of <b>OperationMetadata</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>package modify</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The configuration parameter.</para>
        /// <para>This parameter is available if the service provider set <b>Method</b> to <b>Change Parameter</b> when configuring configuration change operations.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To obtain the parameters of the service that support configuration change, you can call the <a href="https://help.aliyun.com/document_detail/2340828.html">GetService</a> operation. In the response, check the value of <b>ModifyParametersConfig</b> in the value of <b>OperationMetadata</b>.</para>
        /// </description></item>
        /// <item><description><para>You can also view the parameters of the service that support configuration change in the <b>configuration change</b> dialog box in the <a href="https://computenest.console.aliyun.com/service/instance/cn-hangzhou">Compute Nest console</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>For example, if the service supports Elastic Compute Service (ECS) instance type upgrade, you must specify an instance type that has higher specifications than the current one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;InstanceType&quot;: &quot;ecs.g8ise.2xlarge&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The name of the configuration plan.</para>
        /// <para>This parameter is available if the service provider set <b>Method</b> to <b>Change Plan</b> when configuring configuration change operations.</para>
        /// <para>To obtain the configuration plan names of the service, you can call the <a href="https://help.aliyun.com/document_detail/2340828.html">GetService</a> operation. In the response, check the value of <b>PredefinedParameters</b> in the value of <b>DeployMetadata</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>package One</para>
        /// </summary>
        [NameInMap("PredefinedParametersName")]
        [Validation(Required=false)]
        public string PredefinedParametersName { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/396200.html">ListServiceInstances</a> operation to obtain the ID of the service instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
