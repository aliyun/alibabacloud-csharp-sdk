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
            /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
        /// <para>Specifies whether to perform only a dry run for the request to check information such as the permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true: performs a dry run for the request, but does not create a service instance.</b></description></item>
        /// <item><description><b>false: performs a dry run for the request, and creates a service instance if the request passes the dry run.</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Prometheus on the customer side. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// <para>The name of the configuration update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>package modify</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the service instance.</para>
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
        /// <para>The name of the specification package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>package One</para>
        /// </summary>
        [NameInMap("PredefinedParametersName")]
        [Validation(Required=false)]
        public string PredefinedParametersName { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
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
