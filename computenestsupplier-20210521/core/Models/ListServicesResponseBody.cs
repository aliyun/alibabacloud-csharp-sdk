// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
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
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The approval type for service usage requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Manual: Manual approval.</para>
            /// </description></item>
            /// <item><description><para>AutoPass: Automatic approval.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoPass</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            /// <summary>
            /// <para>The artifact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact-21ca53ac16a643****</para>
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The artifact version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>draft</para>
            /// </summary>
            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            /// <summary>
            /// <para>The information about the service build.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;RepoUrl&quot;: &quot;<a href="https://github.com/user/example.git">https://github.com/user/example.git</a>&quot;, &quot;Brancn&quot;: &quot;main&quot;}</para>
            /// </summary>
            [NameInMap("BuildInfo")]
            [Validation(Required=false)]
            public string BuildInfo { get; set; }

            /// <summary>
            /// <para>The service category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenSource</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public string Categories { get; set; }

            /// <summary>
            /// <para>The commodity specifications.</para>
            /// </summary>
            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public ListServicesResponseBodyServicesCommodity Commodity { get; set; }
            public class ListServicesResponseBodyServicesCommodity : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00****</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The metadata of the SaaS Boost configuration.</para>
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
                /// <para>The type. Valid values:</para>
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
            /// <para>The commodity code of the service in Alibaba Cloud Marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmjj00****</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The time when the service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-20T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is the default version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: The service is not the default version.</para>
            /// </description></item>
            /// <item><description><para>true: The service is the default version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            /// <summary>
            /// <para>The deployment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ros: The service is deployed using ROS.</para>
            /// </description></item>
            /// <item><description><para>terraform: The service is deployed using Terraform.</para>
            /// </description></item>
            /// <item><description><para>spi: The service is deployed by calling an SPI.</para>
            /// </description></item>
            /// <item><description><para>operation: The service is deployed using Alibaba Cloud Managed Services.</para>
            /// </description></item>
            /// <item><description><para>container: The service is deployed using a container.</para>
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
            /// <para>Indicates whether the service has a beta version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasBeta")]
            [Validation(Required=false)]
            public bool? HasBeta { get; set; }

            /// <summary>
            /// <para>Indicates whether the service has a draft version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasDraft")]
            [Validation(Required=false)]
            public bool? HasDraft { get; set; }

            /// <summary>
            /// <para>The latest version of the source service for distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LatestResellSourceServiceVersion")]
            [Validation(Required=false)]
            public string LatestResellSourceServiceVersion { get; set; }

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
            /// <para>The artifact association type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ServiceDeployment: Service deployment.</para>
            /// </description></item>
            /// <item><description><para>ServiceUpgrade: Service upgrade.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceDeployment</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The distribution authorization status of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CanApply: You can apply for authorization.</para>
            /// </description></item>
            /// <item><description><para>Applied: An application has been submitted.</para>
            /// </description></item>
            /// <item><description><para>Approved: The application is approved.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CanApply</para>
            /// </summary>
            [NameInMap("ResellApplyStatus")]
            [Validation(Required=false)]
            public string ResellApplyStatus { get; set; }

            /// <summary>
            /// <para>The ID of the distributed service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-70a3b15bb62643****</para>
            /// </summary>
            [NameInMap("ResellServiceId")]
            [Validation(Required=false)]
            public string ResellServiceId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz5b555****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is discoverable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>INVISIBLE: Not discoverable.</para>
            /// </description></item>
            /// <item><description><para>DISCOVERABLE: Discoverable.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>INVISIBLE</para>
            /// </summary>
            [NameInMap("ServiceDiscoverable")]
            [Validation(Required=false)]
            public string ServiceDiscoverable { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-70a3b15bb62643****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The service information.</para>
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceInfos> ServiceInfos { get; set; }
            public class ListServicesResponseBodyServicesServiceInfos : TeaModel {
                /// <summary>
                /// <para>The URL of the service icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.example.oss.url">http://img.example.oss.url</a></para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The language of the service configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>zh-CN: Chinese.</para>
                /// </description></item>
                /// <item><description><para>en-US: English.</para>
                /// </description></item>
                /// </list>
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
                /// <para>A brief description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            /// <summary>
            /// <para>The multi-language configurations of the service.</para>
            /// </summary>
            [NameInMap("ServiceLocaleConfigs")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
            public class ListServicesResponseBodyServicesServiceLocaleConfigs : TeaModel {
                /// <summary>
                /// <para>The English value of the business information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service Name</para>
                /// </summary>
                [NameInMap("EnValue")]
                [Validation(Required=false)]
                public string EnValue { get; set; }

                /// <summary>
                /// <para>The original value of the business information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Service Name</para>
                /// </summary>
                [NameInMap("OriginalValue")]
                [Validation(Required=false)]
                public string OriginalValue { get; set; }

                /// <summary>
                /// <para>The Chinese value of the business information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>服务名称</para>
                /// </summary>
                [NameInMap("ZhValue")]
                [Validation(Required=false)]
                public string ZhValue { get; set; }

            }

            /// <summary>
            /// <para>The service type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>private: The service is deployed in the user\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>managed: The service is deployed in the service provider\&quot;s account.</para>
            /// </description></item>
            /// <item><description><para>operation: It is an Alibaba Cloud Managed Service.</para>
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
            /// <para>The sharing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Public: Public. Official and trial deployments are not restricted.</para>
            /// </description></item>
            /// <item><description><para>Restricted: Restricted. Official and trial deployments are restricted.</para>
            /// </description></item>
            /// <item><description><para>OnlyFormalRestricted: Only official deployments are restricted.</para>
            /// </description></item>
            /// <item><description><para>OnlyTrailRestricted: Only trial deployments are restricted.</para>
            /// </description></item>
            /// <item><description><para>Hidden: Hidden. The service is not visible and you cannot request deployment permissions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The source image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos_7</para>
            /// </summary>
            [NameInMap("SourceImage")]
            [Validation(Required=false)]
            public string SourceImage { get; set; }

            /// <summary>
            /// <para>The ID of the source service for distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-70a3b15bb62643****</para>
            /// </summary>
            [NameInMap("SourceServiceId")]
            [Validation(Required=false)]
            public string SourceServiceId { get; set; }

            /// <summary>
            /// <para>The version of the source service for distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceServiceVersion")]
            [Validation(Required=false)]
            public string SourceServiceVersion { get; set; }

            /// <summary>
            /// <para>The name of the source service provider for distribution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SourceSupplier</para>
            /// </summary>
            [NameInMap("SourceSupplierName")]
            [Validation(Required=false)]
            public string SourceSupplierName { get; set; }

            /// <summary>
            /// <para>The service status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Draft: The service is in the Draft state.</para>
            /// </description></item>
            /// <item><description><para>Submitted: The service is submitted for review. Modifications are not allowed.</para>
            /// </description></item>
            /// <item><description><para>Approved: The service is approved. Modifications are not allowed. The service can be published.</para>
            /// </description></item>
            /// <item><description><para>Launching: The service is being published.</para>
            /// </description></item>
            /// <item><description><para>Online: The service is published.</para>
            /// </description></item>
            /// <item><description><para>Offline: The service is unpublished.</para>
            /// </description></item>
            /// </list>
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
            /// <para>The URL of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            /// <summary>
            /// <para>The service tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListServicesResponseBodyServicesTags : TeaModel {
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
            /// <para>The tenant type for the managed service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SingleTenant: Single-tenant.</para>
            /// </description></item>
            /// <item><description><para>MultiTenant: Multi-tenant.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SingleTenant</para>
            /// </summary>
            [NameInMap("TenantType")]
            [Validation(Required=false)]
            public string TenantType { get; set; }

            /// <summary>
            /// <para>The trial policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Trial: The service supports a trial.</para>
            /// </description></item>
            /// <item><description><para>NotTrial: The service does not support a trial.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trial</para>
            /// </summary>
            [NameInMap("TrialType")]
            [Validation(Required=false)]
            public string TrialType { get; set; }

            /// <summary>
            /// <para>The time when the service was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
            /// <para>v2.0.0</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is a virtual Internet service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: No.</para>
            /// </description></item>
            /// <item><description><para>true: Yes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VirtualInternetService")]
            [Validation(Required=false)]
            public string VirtualInternetService { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that meet the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
