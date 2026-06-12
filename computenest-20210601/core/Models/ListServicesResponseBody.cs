// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServicesResponseBody : TeaModel {
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
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI41</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3F976EF8-C10A-57DC-917C-BB7BEB508FFB</para>
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
            /// <para>The category of the data disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency: ultra disk.</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD.</para>
            /// </description></item>
            /// <item><description><para>cloud_essd: ESSD.</para>
            /// </description></item>
            /// <item><description><para>cloud: basic disk.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
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
                /// <para>The commodity specification code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj00****</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The deployment page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Order: Order page
                /// Detail: Details page</para>
                /// </summary>
                [NameInMap("DeployPage")]
                [Validation(Required=false)]
                public string DeployPage { get; set; }

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
            /// <para>The deployment source of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoWhere: The service has no deployment source.</para>
            /// </description></item>
            /// <item><description><para>Marketplace: The service is deployed from Alibaba Cloud Marketplace.</para>
            /// </description></item>
            /// <item><description><para>ComputeNest: The service is deployed from Compute Nest.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ComputeNest</para>
            /// </summary>
            [NameInMap("DeployFrom")]
            [Validation(Required=false)]
            public string DeployFrom { get; set; }

            /// <summary>
            /// <para>The deployment type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ros: The service is deployed using ROS.</para>
            /// </description></item>
            /// <item><description><para>terraform: The service is deployed using Terraform.</para>
            /// </description></item>
            /// <item><description><para>spi: The service is deployed by calling SPI.</para>
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
            /// <para>The time when the service was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-21T10:35:44Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The service score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>The service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-6b5d632edd394dxxxxxx</para>
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
                /// <para><a href="http://img.tidb.oss.url">http://img.tidb.oss.url</a></para>
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
                /// <para>The service overview.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B is an open-source distributed relational database independently designed and developed by Company A.</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

                /// <summary>
                /// <para>The software information of the service.</para>
                /// </summary>
                [NameInMap("Softwares")]
                [Validation(Required=false)]
                public List<ListServicesResponseBodyServicesServiceInfosSoftwares> Softwares { get; set; }
                public class ListServicesResponseBodyServicesServiceInfosSoftwares : TeaModel {
                    /// <summary>
                    /// <para>The software name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wordpress</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The software version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.0.1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

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
                /// <para>The raw data value of the business information.</para>
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
            /// <para>The URL of the product page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example1.com">http://example1.com</a></para>
            /// </summary>
            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            /// <summary>
            /// <para>The service type. Valid values:</para>
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
            /// <para>The service status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Draft: The service is in the draft state.</para>
            /// </description></item>
            /// <item><description><para>Submitted: The service is submitted for review. You cannot modify the service.</para>
            /// </description></item>
            /// <item><description><para>Approved: The service is approved. You cannot modify the service, but you can publish it.</para>
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
            /// <para>The service provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Company A Ltd.</para>
            /// </summary>
            [NameInMap("SupplierName")]
            [Validation(Required=false)]
            public string SupplierName { get; set; }

            /// <summary>
            /// <para>The English name of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("SupplierNameEng")]
            [Validation(Required=false)]
            public string SupplierNameEng { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1436322xxxxx</para>
            /// </summary>
            [NameInMap("SupplierUid")]
            [Validation(Required=false)]
            public long? SupplierUid { get; set; }

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
            /// <para>The tenant type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SingleTenant: single-tenant.</para>
            /// </description></item>
            /// <item><description><para>MultiTenant: multi-tenant.</para>
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
            /// <para>The trial duration. Unit: days. The maximum trial duration is 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TrialDuration")]
            [Validation(Required=false)]
            public string TrialDuration { get; set; }

            /// <summary>
            /// <para>The trial type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Trial: The service supports trial.</para>
            /// </description></item>
            /// <item><description><para>NotTrial: The service does not support trial.</para>
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
            /// <para>The service version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
