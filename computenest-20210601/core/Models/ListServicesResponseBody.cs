// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServicesResponseBody : TeaModel {
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
        /// <para>The services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListServicesResponseBodyServices> Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The category of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
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
                /// <para>cmjj00****</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>Deploy Page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Order： Order Page
                /// Detail： Detail Page</para>
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
            /// <para>Service deployment approach. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>NoWhere</para>
            /// </description></item>
            /// <item><description><para>Marketplace</para>
            /// </description></item>
            /// <item><description><para>ComputeNest</para>
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
            /// <para>The deployment type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ros: The service is deployed by using Resource Orchestration Service (ROS).</description></item>
            /// <item><description>terraform: The service is deployed by using Terraform.</description></item>
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
            /// <para>Service recommendation score.</para>
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
                /// <para>Docker Community Edition</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The description of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Docker Community Edition (CE) is a free version of the Docker project, aimed at developers, enthusiasts, and individuals and organizations who want to use container technology.</para>
                /// </summary>
                [NameInMap("ShortDescription")]
                [Validation(Required=false)]
                public string ShortDescription { get; set; }

                /// <summary>
                /// <para>Service software information.</para>
                /// </summary>
                [NameInMap("Softwares")]
                [Validation(Required=false)]
                public List<ListServicesResponseBodyServicesServiceInfosSoftwares> Softwares { get; set; }
                public class ListServicesResponseBodyServicesServiceInfosSoftwares : TeaModel {
                    /// <summary>
                    /// <para>The name of the software.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wordpress</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The version of the software.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.0.1</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

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
            /// <para>The URL of the service page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example1.com">http://example1.com</a></para>
            /// </summary>
            [NameInMap("ServiceProductUrl")]
            [Validation(Required=false)]
            public string ServiceProductUrl { get; set; }

            /// <summary>
            /// <para>The type of the service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>private: The service is a private service and is deployed within the account of a customer.</description></item>
            /// <item><description>managed: The service is a fully managed service and is deployed within the account of a service provider.</description></item>
            /// <item><description>operation: The service is a hosted O&amp;M service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

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
            /// <para>The name of service provider.</para>
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
            /// <para>The URL of the service provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.com">http://example.com</a></para>
            /// </summary>
            [NameInMap("SupplierUrl")]
            [Validation(Required=false)]
            public string SupplierUrl { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesTags> Tags { get; set; }
            public class ListServicesResponseBodyServicesTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// <remarks>
                /// <para> This parameter is required.</para>
                /// </remarks>
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
            /// <para>The trial duration. Unit: day. The maximum trial duration cannot exceed 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TrialDuration")]
            [Validation(Required=false)]
            public string TrialDuration { get; set; }

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
            /// <para>The version of the service.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
