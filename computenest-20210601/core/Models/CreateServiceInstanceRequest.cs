// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information about the order placed in Alibaba Cloud Marketplace. You do not need to specify this parameter if the service is not published in Alibaba Cloud Marketplace or uses the pay-as-you-go billing method.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public CreateServiceInstanceRequestCommodity Commodity { get; set; }
        public class CreateServiceInstanceRequestCommodity : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically complete the payment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal for the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            /// <summary>
            /// <para>The coupon ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>302070970220</para>
            /// </summary>
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
            public long? PayPeriod { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Year</b></description></item>
            /// <item><description><b>Month</b></description></item>
            /// <item><description><b>Day</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PayPeriodUnit")]
            [Validation(Required=false)]
            public string PayPeriodUnit { get; set; }

            [NameInMap("QuotationId")]
            [Validation(Required=false)]
            public string QuotationId { get; set; }

        }

        /// <summary>
        /// <para>The alert contact group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default Group</para>
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request to check information such as the permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run for the request, but does not create a service instance.</description></item>
        /// <item><description><b>false</b>: performs a dry run for the request, and creates a service instance if the request passes the dry run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether the service instance supports the hosted O\&amp;M feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Prometheus monitoring feature. Valid values:</para>
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
        /// <para>The serviceInstance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The operation metadata.</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public CreateServiceInstanceRequestOperationMetadata OperationMetadata { get; set; }
        public class CreateServiceInstanceRequestOperationMetadata : TeaModel {
            /// <summary>
            /// <para>The operation end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-28T06:48:56Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <pre><code class="language-json">  {
            ///     &quot;vncInfo&quot;: [
            ///       {
            ///         &quot;instanceId&quot;: &quot;i-001&quot;,
            ///         &quot;username&quot;: &quot;admin&quot;,
            ///         &quot;password&quot;: &quot;******&quot;,
            ///         &quot;vncPassword&quot;: &quot;******&quot;
            ///       }
            ///     ]
            ///   }
            /// </c></pre>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>Imported resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,   &quot;Type&quot;: &quot;ResourceIds&quot;,   &quot;ResourceIds&quot;: {     &quot;ALIYUN::ECS::INSTANCE&quot;: [&quot;i-xxx&quot;, &quot;i-yyy&quot;],     &quot;ALIYUN::RDS::INSTANCE&quot;: [&quot;rm-xxx&quot;, &quot;rm-yyy&quot;],     &quot;ALIYUN::VPC::VPC&quot;: [&quot;vpc-xxx&quot;, &quot;vpc-yyy&quot;],     &quot;ALIYUN::SLB::INSTANCE&quot;: [&quot;lb-xxx&quot;, &quot;lb-yyy&quot;]   } }</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The ID of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-d6ab3a63ccbb4b17****</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The operation start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T06:48:56Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The parameters that the customer specifies to deploy the service instance.</para>
        /// <remarks>
        /// <para> If region information is required to create a service instance, you must specify the region ID in the value of Parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;NodeCount&quot;: 3, &quot;SystemDiskSize&quot;: 40, &quot;InstancePassword&quot;: &quot;******&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The region ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: China (Hangzhou).</description></item>
        /// <item><description>ap-southeast-1: Singapore.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically deduct the resource fees from the account balance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceAutoPay")]
        [Validation(Required=false)]
        public bool? ResourceAutoPay { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0e6fca6a51a54420****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The trial service instance id witch you want to convert to formal</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d32fbcef30664721b785</para>
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
        /// <para>Specification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yuncode5425200001</para>
        /// </summary>
        [NameInMap("SpecificationCode")]
        [Validation(Required=false)]
        public string SpecificationCode { get; set; }

        /// <summary>
        /// <para>The package name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default Ppackage</para>
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceInstanceRequestTag> Tag { get; set; }
        public class CreateServiceInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS Template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The trial type of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Trial</b>: Trials are supported.</description></item>
        /// <item><description><b>NotTrial</b>: Trials are not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Trial</para>
        /// </summary>
        [NameInMap("TrialType")]
        [Validation(Required=false)]
        public string TrialType { get; set; }

    }

}
