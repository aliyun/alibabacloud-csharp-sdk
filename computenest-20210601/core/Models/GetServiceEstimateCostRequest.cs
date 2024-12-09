// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceEstimateCostRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwertyuiop</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity details.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public GetServiceEstimateCostRequestCommodity Commodity { get; set; }
        public class GetServiceEstimateCostRequestCommodity : TeaModel {
            [NameInMap("CouponId")]
            [Validation(Required=false)]
            public string CouponId { get; set; }

            /// <summary>
            /// <para>The subscription duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayPeriod")]
            [Validation(Required=false)]
            public int? PayPeriod { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Year</description></item>
            /// <item><description>Month</description></item>
            /// <item><description>Day</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PayPeriodUnit")]
            [Validation(Required=false)]
            public string PayPeriodUnit { get; set; }

        }

        /// <summary>
        /// <para>The name of the configuration update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>修改游戏参数</para>
        /// </summary>
        [NameInMap("OperationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        /// <summary>
        /// <para>The parameters that are specified for service instance deployment.</para>
        /// <remarks>
        /// <para> If you want to specify the region in which the service instance is deployed, you must specify the information in Parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{ \&quot;RegionId\&quot;: \&quot;cn-hangzhou\&quot;, \&quot;InstanceType\&quot;: \&quot;ecs.g5.large\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-12xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17xxxx</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The service version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自定义套餐</para>
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// <para>The name of the template. This parameter is returned only if you specify TemplateId.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify TemplateVersion, the name of the template whose version is specified by TemplateVersion is returned.</description></item>
        /// <item><description>If you not specify TemplateVersion, the name of the template whose version is the default version is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>模板1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The trial policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Trial: Trials are supported.</description></item>
        /// <item><description>NotTrial: Trials are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NotTrial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
