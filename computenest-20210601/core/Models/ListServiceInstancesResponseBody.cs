// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E50287CB-AABF-4877-92C0-289B339A1546</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about service instances.</para>
        /// </summary>
        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
            /// <summary>
            /// <para>The business state of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Renewing</description></item>
            /// <item><description>RenewFailed</description></item>
            /// <item><description>Expired</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <para>The time when the service instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the service instance supports the hosted O\&amp;M feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInstanceOps")]
            [Validation(Required=false)]
            public bool? EnableInstanceOps { get; set; }

            /// <summary>
            /// <para>The time when the service instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud Marketplace instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5827****</para>
            /// </summary>
            [NameInMap("MarketInstanceId")]
            [Validation(Required=false)]
            public string MarketInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the managed service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-d6ab3a63ccbb4b17****</para>
            /// </summary>
            [NameInMap("OperatedServiceInstanceId")]
            [Validation(Required=false)]
            public string OperatedServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The end of the time range during which hosted O\&amp;M is implemented.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-28T06:48:56Z</para>
            /// </summary>
            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which hosted O\&amp;M is implemented.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-29T06:48:56Z</para>
            /// </summary>
            [NameInMap("OperationStartTime")]
            [Validation(Required=false)]
            public string OperationStartTime { get; set; }

            /// <summary>
            /// <para>The order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2306175xxxxxxxx</para>
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            /// <summary>
            /// <para>The information returned after the service instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;managementUrl&quot;: &quot;<a href="http://xx.xx%22%7D">http://xx.xx&quot;}</a></para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The parameters of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;param&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Permanent: Once you purchase the service, you can use it permanently.</description></item>
            /// <item><description>Subscription: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a subscription basis.</description></item>
            /// <item><description>PayAsYouGo: You purchase the service from Alibaba Cloud Marketplace and are charged for the service on a pay-as-you-go basis.</description></item>
            /// <item><description>CustomFixTime: You are charged for the service based on a custom duration fixed by the service provider.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The deployment progress of the service instance, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public long? Progress { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz6scpcxxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;StackId&quot;: &quot;stack-xxx&quot;}]</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The services.</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
                /// <summary>
                /// <para>The commodity details.</para>
                /// </summary>
                [NameInMap("Commodity")]
                [Validation(Required=false)]
                public ListServiceInstancesResponseBodyServiceInstancesServiceCommodity Commodity { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceCommodity : TeaModel {
                    /// <summary>
                    /// <para>The configuration metadata related to SaaS Boost.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{ // Specifies whether to associate the service with the SaaS Boost commodity. Default value: false. &quot;Enabled&quot;:true/false // The public endpoint of the SaaS Boost instance. &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot; }</para>
                    /// </summary>
                    [NameInMap("SaasBoostMetadata")]
                    [Validation(Required=false)]
                    public string SaasBoostMetadata { get; set; }

                    /// <summary>
                    /// <para>The platform type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>marketplace: Alibaba Cloud Marketplace.</description></item>
                    /// <item><description>Css: Lingxiao.</description></item>
                    /// <item><description>SaasBoost: SaaS Boost.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Marketplace</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The deployment type of the service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
                /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
                /// <item><description>ack: The service is deployed by using Alibaba Cloud Container Service for Kubernetes (ACK).</description></item>
                /// <item><description>spi: The service is deployed by calling the Service Provider Interface (SPI).</description></item>
                /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ros</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The time when the service was published.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-21T00:00:00Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>The service ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service-0e6fca6a51a54420****</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The information about the service.</para>
                /// </summary>
                [NameInMap("ServiceInfos")]
                [Validation(Required=false)]
                public List<ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos> ServiceInfos { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceServiceInfos : TeaModel {
                    /// <summary>
                    /// <para>The URL of the service icon.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png">https://example.com/service-image/c1c4a559-cc60-4af1-b976-98f356602462.png</a></para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                    /// <summary>
                    /// <para>The language of the service instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zh-CN</para>
                    /// </summary>
                    [NameInMap("Locale")]
                    [Validation(Required=false)]
                    public string Locale { get; set; }

                    /// <summary>
                    /// <para>The name of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wordpress</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The description of the service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WordPress is a free and open-source website content management system (CMS).</para>
                    /// </summary>
                    [NameInMap("ShortDescription")]
                    [Validation(Required=false)]
                    public string ShortDescription { get; set; }

                }

                /// <summary>
                /// <para>The type of the service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
                /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
                /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The service state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Online</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The name of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud</para>
                /// </summary>
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                /// <summary>
                /// <para>The URL of the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example.com">http://example.com</a></para>
                /// </summary>
                [NameInMap("SupplierUrl")]
                [Validation(Required=false)]
                public string SupplierUrl { get; set; }

                /// <summary>
                /// <para>The service version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The custom version name defined by the service provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.0</para>
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

            /// <summary>
            /// <para>The service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-d6ab3a63ccbb4b17****</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
            /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
            /// <item><description>operation: The service is a hosted O\&amp;M service.</description></item>
            /// <item><description>poc: The service is a trial service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The source from which the service instance is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Supplier</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The state of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created</description></item>
            /// <item><description>Deploying</description></item>
            /// <item><description>DeployedFailed</description></item>
            /// <item><description>Deployed</description></item>
            /// <item><description>Upgrading</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>Deleted</description></item>
            /// <item><description>DeletedFailed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the deployment of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deploy successfully</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            /// <summary>
            /// <para>Is it supported to convert from trial to formal</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportTrialToPrivate")]
            [Validation(Required=false)]
            public bool? SupportTrialToPrivate { get; set; }

            /// <summary>
            /// <para>The custom tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServiceInstancesResponseBodyServiceInstancesTags> Tags { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesTags : TeaModel {
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
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Single ECS</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The time when the service instance was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
