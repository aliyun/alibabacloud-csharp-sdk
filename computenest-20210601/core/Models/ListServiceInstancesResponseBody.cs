// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
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
        /// <para>The information about the service instances.</para>
        /// </summary>
        [NameInMap("ServiceInstances")]
        [Validation(Required=false)]
        public List<ListServiceInstancesResponseBodyServiceInstances> ServiceInstances { get; set; }
        public class ListServiceInstancesResponseBodyServiceInstances : TeaModel {
            /// <summary>
            /// <para>The business status of the service instance. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Normal: The service instance is running as expected.</para>
            /// </description></item>
            /// <item><description><para>Renewing: The service instance is being renewed.</para>
            /// </description></item>
            /// <item><description><para>RenewFoiled: The renewal of the service instance failed.</para>
            /// </description></item>
            /// <item><description><para>Expired: The service instance has expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the service instance has the Alibaba Cloud Managed Services feature. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The service instance has the Alibaba Cloud Managed Services feature.</para>
            /// </description></item>
            /// <item><description><para>false: The service instance does not have the Alibaba Cloud Managed Services feature.</para>
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
            /// <para>The expiration time of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("GrantedPermission")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesGrantedPermission GrantedPermission { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesGrantedPermission : TeaModel {
                [NameInMap("OperationEndTime")]
                [Validation(Required=false)]
                public string OperationEndTime { get; set; }

                [NameInMap("PolicyNames")]
                [Validation(Required=false)]
                public string PolicyNames { get; set; }

            }

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
            /// <para>The ID of the service instance that is managed by Alibaba Cloud.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-d6ab3a63ccbb4b17****</para>
            /// </summary>
            [NameInMap("OperatedServiceInstanceId")]
            [Validation(Required=false)]
            public string OperatedServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The end time of the Alibaba Cloud Managed Services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-28T06:48:56Z</para>
            /// </summary>
            [NameInMap("OperationEndTime")]
            [Validation(Required=false)]
            public string OperationEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the Alibaba Cloud Managed Services.</para>
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
            /// <para>The output information of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;managementUrl&quot;: &quot;<a href="http://xx.xx%22%7D">http://xx.xx&quot;}</a></para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public string Outputs { get; set; }

            /// <summary>
            /// <para>The parameter information of the service instance.</para>
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
            /// <item><description><para>Permanent: The service is purchased permanently.</para>
            /// </description></item>
            /// <item><description><para>Subscription: The service is a subscription instance from Alibaba Cloud Marketplace.</para>
            /// </description></item>
            /// <item><description><para>PayAsYouGo: The service is a pay-as-you-go instance from Alibaba Cloud Marketplace.</para>
            /// </description></item>
            /// <item><description><para>CustomFixTime: The service has a custom fixed duration.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("PolicyNames")]
            [Validation(Required=false)]
            public string PolicyNames { get; set; }

            /// <summary>
            /// <para>The deployment progress of the service instance. Unit: %.</para>
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
            /// <para>The list of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;StackId&quot;: &quot;stack-xxx&quot;}]</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public string Resources { get; set; }

            /// <summary>
            /// <para>The service.</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public ListServiceInstancesResponseBodyServiceInstancesService Service { get; set; }
            public class ListServiceInstancesResponseBodyServiceInstancesService : TeaModel {
                /// <summary>
                /// <para>The commodity specifications.</para>
                /// </summary>
                [NameInMap("Commodity")]
                [Validation(Required=false)]
                public ListServiceInstancesResponseBodyServiceInstancesServiceCommodity Commodity { get; set; }
                public class ListServiceInstancesResponseBodyServiceInstancesServiceCommodity : TeaModel {
                    /// <summary>
                    /// <para>The metadata of the Software as a Service (SaaS) Boost configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///      //Enable/disable SaaS Boost binding
                    ///     &quot;Enabled&quot;:true/false,default is false
                    ///     //Public access URL
                    ///     &quot;PublicAccessUrl&quot;:&quot;<a href="https://example.com">https://example.com</a>&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("SaasBoostMetadata")]
                    [Validation(Required=false)]
                    public string SaasBoostMetadata { get; set; }

                    /// <summary>
                    /// <para>The type. Possible values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Marketplace: Alibaba Cloud Marketplace.</para>
                    /// </description></item>
                    /// <item><description><para>Css: Lingxiao.</para>
                    /// </description></item>
                    /// <item><description><para>SaasBoost: SaaS Boost.</para>
                    /// </description></item>
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
                /// <para>The deployment type. Possible values:</para>
                /// <list type="bullet">
                /// <item><description><para>ros: The service is deployed using ROS.</para>
                /// </description></item>
                /// <item><description><para>terraform: The service is deployed using Terraform.</para>
                /// </description></item>
                /// <item><description><para>ack: The service is deployed using ACK.</para>
                /// </description></item>
                /// <item><description><para>spi: The service is deployed by calling SPI.</para>
                /// </description></item>
                /// <item><description><para>operation: The service is deployed using Alibaba Cloud Managed Services.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ros</para>
                /// </summary>
                [NameInMap("DeployType")]
                [Validation(Required=false)]
                public string DeployType { get; set; }

                /// <summary>
                /// <para>The publishing time.</para>
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
                /// <para>The service information.</para>
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
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Database B</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The service overview.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
                    /// </summary>
                    [NameInMap("ShortDescription")]
                    [Validation(Required=false)]
                    public string ShortDescription { get; set; }

                }

                /// <summary>
                /// <para>The service type. Possible values:</para>
                /// <list type="bullet">
                /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
                /// </description></item>
                /// <item><description><para>managed: The service is hosted in the service provider\&quot;s account.</para>
                /// </description></item>
                /// <item><description><para>operation: The service is an Alibaba Cloud Managed Service.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>private</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The service status.</para>
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
                /// <para>Company A Ltd.</para>
                /// </summary>
                [NameInMap("SupplierName")]
                [Validation(Required=false)]
                public string SupplierName { get; set; }

                /// <summary>
                /// <para>The service provider\&quot;s URL.</para>
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
                /// <para>Version A</para>
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
            /// <para>The service type. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>managed: The service is hosted in the service provider\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>operation: The service is an Alibaba Cloud Managed Service.</para>
            /// </description></item>
            /// <item><description><para>poc: The service instance is a trial instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <para>The source from which the service instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Supplier</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the service instance. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para>Created: The service instance is created.</para>
            /// </description></item>
            /// <item><description><para>Deploying: The service instance is being deployed.</para>
            /// </description></item>
            /// <item><description><para>DeployedFailed: The service instance failed to be deployed.</para>
            /// </description></item>
            /// <item><description><para>Deployed: The service instance is deployed.</para>
            /// </description></item>
            /// <item><description><para>Upgrading: The service instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>Deleting: The service instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The service instance is deleted.</para>
            /// </description></item>
            /// <item><description><para>DeletedFailed: The service instance failed to be deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the deployment information of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deploy successfully</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

            /// <summary>
            /// <para>Indicates whether the trial instance can be converted to a regular instance.</para>
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
            /// <para>Template 1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
