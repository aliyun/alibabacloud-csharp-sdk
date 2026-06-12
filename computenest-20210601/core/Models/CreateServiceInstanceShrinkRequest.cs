// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class CreateServiceInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated, unique token that ensures the idempotence of the request. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The information about the Alibaba Cloud Marketplace purchase order. You do not need to specify this parameter if the service is not listed in Alibaba Cloud Marketplace or if you use the pay-as-you-go billing method.</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public CreateServiceInstanceShrinkRequestCommodity Commodity { get; set; }
        public class CreateServiceInstanceShrinkRequestCommodity : TeaModel {
            /// <summary>
            /// <para>Indicates whether to enable automatic payment for the order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable automatic payment.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disable automatic payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoPay")]
            [Validation(Required=false)]
            public bool? AutoPay { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable auto-renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enable.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disable.</para>
            /// </description></item>
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
            /// <item><description><para><b>Year</b>: Year.</para>
            /// </description></item>
            /// <item><description><para><b>Month</b>: Month.</para>
            /// </description></item>
            /// <item><description><para><b>Day</b>: Day.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Year</para>
            /// </summary>
            [NameInMap("PayPeriodUnit")]
            [Validation(Required=false)]
            public string PayPeriodUnit { get; set; }

            /// <summary>
            /// <para>The ID of the private offer in Alibaba Cloud Marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx-xxxx-xxxx-xxxx</para>
            /// </summary>
            [NameInMap("QuotationId")]
            [Validation(Required=false)]
            public string QuotationId { get; set; }

        }

        /// <summary>
        /// <para>The CloudMonitor alert contact group that receives alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud account alert contact</para>
        /// </summary>
        [NameInMap("ContactGroup")]
        [Validation(Required=false)]
        public string ContactGroup { get; set; }

        /// <summary>
        /// <para>Indicates whether to perform a dry run for the request. The dry run checks for permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends the request without creating the service instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Sends the request and creates the service instance after the check is passed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Indicates whether the service instance has the O\&amp;M feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The service instance has the O\&amp;M feature.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The service instance does not have the O\&amp;M feature.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableInstanceOps")]
        [Validation(Required=false)]
        public bool? EnableInstanceOps { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable Prometheus monitoring. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableUserPrometheus")]
        [Validation(Required=false)]
        public bool? EnableUserPrometheus { get; set; }

        /// <summary>
        /// <para>The name of the service instance. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name can be up to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter or a digit and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TestName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The O\&amp;M configuration.</para>
        /// </summary>
        [NameInMap("OperationMetadata")]
        [Validation(Required=false)]
        public CreateServiceInstanceShrinkRequestOperationMetadata OperationMetadata { get; set; }
        public class CreateServiceInstanceShrinkRequestOperationMetadata : TeaModel {
            /// <summary>
            /// <para>The end time of the O\&amp;M window. This parameter is valid only in managed O\&amp;M mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-28T06:48:56Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Additional information about the managed O\&amp;M service.</para>
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
            /// <para>The list of imported resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,   &quot;Type&quot;: &quot;ResourceIds&quot;,   &quot;ResourceIds&quot;: {     &quot;ALIYUN::ECS::INSTANCE&quot;: [&quot;i-xxx&quot;, &quot;i-yyy&quot;],     &quot;ALIYUN::RDS::INSTANCE&quot;: [&quot;rm-xxx&quot;, &quot;rm-yyy&quot;],     &quot;ALIYUN::VPC::VPC&quot;: [&quot;vpc-xxx&quot;, &quot;vpc-yyy&quot;],     &quot;ALIYUN::SLB::INSTANCE&quot;: [&quot;lb-xxx&quot;, &quot;lb-yyy&quot;]   } }</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The ID of the imported service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-d6ab3a63ccbb4b17****</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The start time of the O\&amp;M window. This parameter is valid only in managed O\&amp;M mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T06:48:56Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The parameters for deploying the user instance.</para>
        /// <remarks>
        /// <para>If the service instance contains deployment region information, you must specify the region in the deployment parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
        ///       &quot;NodeCount&quot;: 3,
        ///       &quot;SystemDiskSize&quot;: 40,
        ///       &quot;InstancePassword&quot;: &quot;******&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string ParametersShrink { get; set; }

        /// <summary>
        /// <para>The region ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: China (Hangzhou).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Singapore.</para>
        /// </description></item>
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
        /// <para>Indicates whether to automatically deduct the payment from your account balance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable automatic payment.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable automatic payment.</para>
        /// </description></item>
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
        /// <para>The ID of the service instance to convert to a paid instance.</para>
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
        /// <para>The commodity specification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yuncode5425200001</para>
        /// </summary>
        [NameInMap("SpecificationCode")]
        [Validation(Required=false)]
        public string SpecificationCode { get; set; }

        /// <summary>
        /// <para>The name of the specification package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Package 1</para>
        /// </summary>
        [NameInMap("SpecificationName")]
        [Validation(Required=false)]
        public string SpecificationName { get; set; }

        /// <summary>
        /// <para>The custom tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServiceInstanceShrinkRequestTag> Tag { get; set; }
        public class CreateServiceInstanceShrinkRequestTag : TeaModel {
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
        /// <para>The template name. You must specify this parameter if the service supports multiple templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Template 1</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Trial</b>: The service instance supports trial.</para>
        /// </description></item>
        /// <item><description><para><b>NotTrial</b>: The service instance does not support trial.</para>
        /// </description></item>
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
