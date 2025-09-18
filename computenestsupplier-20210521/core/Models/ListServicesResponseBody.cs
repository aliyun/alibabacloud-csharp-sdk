// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The approval type for applications for using the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The applications are manual reviewed.</description></item>
            /// <item><description>AutoPass: The applications are automatically approved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoPass</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public string ApprovalType { get; set; }

            /// <summary>
            /// <para>The ID of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>artifact-21ca53ac16a643xxxxxx</para>
            /// </summary>
            [NameInMap("ArtifactId")]
            [Validation(Required=false)]
            public string ArtifactId { get; set; }

            /// <summary>
            /// <para>The version of the artifact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>draft</para>
            /// </summary>
            [NameInMap("ArtifactVersion")]
            [Validation(Required=false)]
            public string ArtifactVersion { get; set; }

            /// <summary>
            /// <para>The informathon for build service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;RepoUrl&quot;: &quot;<a href="https://github.com/user/repo.git">https://github.com/user/repo.git</a>&quot;, &quot;Brancn&quot;: &quot;main&quot;}</para>
            /// </summary>
            [NameInMap("BuildInfo")]
            [Validation(Required=false)]
            public string BuildInfo { get; set; }

            /// <summary>
            /// <para>The category of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenSource</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public string Categories { get; set; }

            /// <summary>
            /// <para>The commodity details.</para>
            /// </summary>
            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public ListServicesResponseBodyServicesCommodity Commodity { get; set; }
            public class ListServicesResponseBodyServicesCommodity : TeaModel {
                /// <summary>
                /// <para>The commodity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00xxxx</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The configuration metadata related to Saas Boost.</para>
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
                /// <item><description>SaasBoost: Saas Boost.</description></item>
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
            /// <para>cmjj00xxxx</para>
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
            /// <para>Indicates whether the version is the default version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DefaultVersion")]
            [Validation(Required=false)]
            public bool? DefaultVersion { get; set; }

            /// <summary>
            /// <para>The deployment type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
            /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
            /// <item><description>spi: The service is deployed by calling the Service Provider Interface (SPI).</description></item>
            /// <item><description>operation: The service is deployed by using a hosted O\&amp;M service.</description></item>
            /// <item><description>container: The service is deployed by using a container.</description></item>
            /// <item><description></description></item>
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
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasDraft")]
            [Validation(Required=false)]
            public bool? HasDraft { get; set; }

            /// <summary>
            /// <para>The latest version of the distribution source service.</para>
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
            /// <para>The purpose of the artifact. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ServiceDeployment: The artifact is used to create service instances.</description></item>
            /// <item><description>ServiceUpgrade: The artifact is used to upgrade service instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceDeployment</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The state of distribution authorization of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CanApply: Distributors can apply for distribution permissions.</description></item>
            /// <item><description>Applied: The application for distribution permissions is submitted.</description></item>
            /// <item><description>Approved: The application for distribution permissions is approved.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CanApply</para>
            /// </summary>
            [NameInMap("ResellApplyStatus")]
            [Validation(Required=false)]
            public string ResellApplyStatus { get; set; }

            /// <summary>
            /// <para>The ID of the distribution service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-70a3b15bb62643xxxxxx</para>
            /// </summary>
            [NameInMap("ResellServiceId")]
            [Validation(Required=false)]
            public string ResellServiceId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekz5b555xxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the service is visible. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INVISIBLE</description></item>
            /// <item><description>DISCOVERABLE</description></item>
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
            /// <para>service-70a3b15bb62643xxxxxx</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The information about the service.</para>
            /// </summary>
            [NameInMap("ServiceInfos")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceInfos> ServiceInfos { get; set; }
            public class ListServicesResponseBodyServicesServiceInfos : TeaModel {
                /// <summary>
                /// <para>The URL of the service icon.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://img.tidb.oss.url">http://img.tidb.oss.url</a></para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The language of the service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>zh-CN: Chinese.</description></item>
                /// <item><description>en-US: English.</description></item>
                /// </list>
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
                /// <para>SpringBoot-ECS容器版</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B是A公司自主设计并研发的开源分布式的关系型数据库</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

            }

            [NameInMap("ServiceLocaleConfigs")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesServiceLocaleConfigs> ServiceLocaleConfigs { get; set; }
            public class ListServicesResponseBodyServicesServiceLocaleConfigs : TeaModel {
                [NameInMap("EnValue")]
                [Validation(Required=false)]
                public string EnValue { get; set; }

                [NameInMap("OriginalValue")]
                [Validation(Required=false)]
                public string OriginalValue { get; set; }

                [NameInMap("ZhValue")]
                [Validation(Required=false)]
                public string ZhValue { get; set; }

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
            /// <para>The permission type of the deployment URL. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Public: All users can go to the URL to create a formal service instance or a trial service instance.</description></item>
            /// <item><description>Restricted: Only users in the whitelist can go to the URL to create a formal service instance or a trial service instance.</description></item>
            /// <item><description>OnlyFormalRestricted: Only users in the whitelist can go to the URL to create a formal service instance.</description></item>
            /// <item><description>OnlyTrailRestricted: Only users in the whitelist can go to the URL to create a trial service instance.</description></item>
            /// <item><description>Hidden: Users not in the whitelist cannot see the service details page when they go to the URL and cannot request deployment permissions.</description></item>
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
            /// <para>The ID of the distribution source service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-70a3b15bb62643xxxxxx</para>
            /// </summary>
            [NameInMap("SourceServiceId")]
            [Validation(Required=false)]
            public string SourceServiceId { get; set; }

            /// <summary>
            /// <para>The version of the distribution source service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceServiceVersion")]
            [Validation(Required=false)]
            public string SourceServiceVersion { get; set; }

            /// <summary>
            /// <para>The name of the distribution source service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SourceSupplier</para>
            /// </summary>
            [NameInMap("SourceSupplierName")]
            [Validation(Required=false)]
            public string SourceSupplierName { get; set; }

            /// <summary>
            /// <para>The state of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Draft: The service is a draft.</description></item>
            /// <item><description>Submitted: The service is submitted for review. You cannot modify services in this state.</description></item>
            /// <item><description>Approved: The service is approved. You cannot modify services in this state. You can publish services in this state.</description></item>
            /// <item><description>Launching: The service is being published.</description></item>
            /// <item><description>Online: The service is published.</description></item>
            /// <item><description>Offline: The service is unpublished.</description></item>
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
            /// <para>The tenant type of the managed service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SingleTenant</description></item>
            /// <item><description>MultiTenant</description></item>
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
            /// <item><description>Trial: Trials are supported.</description></item>
            /// <item><description>NotTrial: Trials are not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Trial</para>
            /// </summary>
            [NameInMap("TrialType")]
            [Validation(Required=false)]
            public string TrialType { get; set; }

            /// <summary>
            /// <para>The time when the service was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-21T00:00:00Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version of the service.</para>
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
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
