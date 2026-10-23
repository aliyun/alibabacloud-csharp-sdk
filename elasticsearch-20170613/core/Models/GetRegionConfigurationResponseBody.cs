// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetRegionConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The region configuration information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRegionConfigurationResponseBodyResult Result { get; set; }
        public class GetRegionConfigurationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The range for the number of client nodes.</para>
            /// </summary>
            [NameInMap("clientNodeAmountRange")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultClientNodeAmountRange ClientNodeAmountRange { get; set; }
            public class GetRegionConfigurationResponseBodyResultClientNodeAmountRange : TeaModel {
                /// <summary>
                /// <para>The maximum number of client nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                /// <summary>
                /// <para>The minimum number of client nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            /// <summary>
            /// <para>The allowed disk values for client nodes.</para>
            /// </summary>
            [NameInMap("clientNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultClientNodeDiskList> ClientNodeDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultClientNodeDiskList : TeaModel {
                /// <summary>
                /// <para>The disk storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <para>The minimum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for continuous disk sizing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

            }

            /// <summary>
            /// <para>The list of client node specifications supported in the current region.</para>
            /// </summary>
            [NameInMap("clientNodeSpec")]
            [Validation(Required=false)]
            public List<string> ClientNodeSpec { get; set; }

            /// <summary>
            /// <para>The URL of the buy page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliyun.com/?commodityCode=elasticsearch&orderType=BUY#/buy">https://common-buy.aliyun.com/?commodityCode=elasticsearch&amp;orderType=BUY#/buy</a></para>
            /// </summary>
            [NameInMap("createUrl")]
            [Validation(Required=false)]
            public string CreateUrl { get; set; }

            /// <summary>
            /// <para>The allowed disk values for data nodes.</para>
            /// </summary>
            [NameInMap("dataDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultDataDiskList> DataDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultDataDiskList : TeaModel {
                /// <summary>
                /// <para>The disk storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5120</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <para>The minimum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for continuous disk sizing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

                /// <summary>
                /// <para>The list of allowed discrete values for the data node disk capacity.</para>
                /// </summary>
                [NameInMap("valueLimitSet")]
                [Validation(Required=false)]
                public List<string> ValueLimitSet { get; set; }

            }

            /// <summary>
            /// <para>The elastic node configuration.</para>
            /// </summary>
            [NameInMap("elasticNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultElasticNodeProperties ElasticNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultElasticNodeProperties : TeaModel {
                /// <summary>
                /// <para>The range for the number of warm nodes.</para>
                /// </summary>
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultElasticNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultElasticNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                /// <summary>
                /// <para>The list of disk configurations.</para>
                /// </summary>
                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether disk encryption can be enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Supported.</description></item>
                    /// <item><description>false: Not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    /// <summary>
                    /// <para>The disk storage type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_ssd</para>
                    /// </summary>
                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <para>The maximum value allowed for the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5120</para>
                    /// </summary>
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    /// <summary>
                    /// <para>The minimum value allowed for the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <para>The maximum value allowed for continuous disk sizing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("scaleLimit")]
                    [Validation(Required=false)]
                    public int? ScaleLimit { get; set; }

                    /// <summary>
                    /// <para>The list of discrete values allowed for the disk capacity of elastic data nodes.</para>
                    /// </summary>
                    [NameInMap("valueLimitSet")]
                    [Validation(Required=false)]
                    public List<string> ValueLimitSet { get; set; }

                }

                /// <summary>
                /// <para>The list of elastic data node specifications supported in the current region.</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            /// <summary>
            /// <para>The environment flag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The list of Elasticsearch versions that can be created in the current region.</para>
            /// </summary>
            [NameInMap("esVersions")]
            [Validation(Required=false)]
            public List<string> EsVersions { get; set; }

            /// <summary>
            /// <para>The list of Elasticsearch versions available for purchase.</para>
            /// </summary>
            [NameInMap("esVersionsLatestList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultEsVersionsLatestList> EsVersionsLatestList { get; set; }
            public class GetRegionConfigurationResponseBodyResultEsVersionsLatestList : TeaModel {
                /// <summary>
                /// <para>The supported major version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.5_with_X-Pack</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The full name of the supported minor version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.5.3_with_X-Pack</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of instance node types available in the current region.</para>
            /// </summary>
            [NameInMap("instanceSupportNodes")]
            [Validation(Required=false)]
            public List<string> InstanceSupportNodes { get; set; }

            /// <summary>
            /// <para>The JVM validation configuration.</para>
            /// </summary>
            [NameInMap("jvmConfine")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultJvmConfine JvmConfine { get; set; }
            public class GetRegionConfigurationResponseBodyResultJvmConfine : TeaModel {
                /// <summary>
                /// <para>The minimum memory size of the specification required to enable JVM garbage collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <para>The list of Elasticsearch versions that support configuring the JVM garbage collector.</para>
                /// </summary>
                [NameInMap("supportEsVersions")]
                [Validation(Required=false)]
                public List<string> SupportEsVersions { get; set; }

                /// <summary>
                /// <para>The list of allowed JVM garbage collectors.</para>
                /// </summary>
                [NameInMap("supportGcs")]
                [Validation(Required=false)]
                public List<string> SupportGcs { get; set; }

            }

            /// <summary>
            /// <para>The Kibana node configuration.</para>
            /// </summary>
            [NameInMap("kibanaNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultKibanaNodeProperties KibanaNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultKibanaNodeProperties : TeaModel {
                /// <summary>
                /// <para>The allowed range for the number of nodes.</para>
                /// </summary>
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultKibanaNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultKibanaNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                /// <summary>
                /// <para>The list of Kibana node specifications supported in the current region.</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            /// <summary>
            /// <para>The list of zones that support Logstash deployment in the current region.</para>
            /// </summary>
            [NameInMap("logstashZones")]
            [Validation(Required=false)]
            public List<string> LogstashZones { get; set; }

            /// <summary>
            /// <para>The allowed disk values for dedicated master nodes.</para>
            /// </summary>
            [NameInMap("masterDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultMasterDiskList> MasterDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultMasterDiskList : TeaModel {
                /// <summary>
                /// <para>The disk storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <para>The minimum value allowed for the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <para>The maximum value allowed for continuous disk sizing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

            }

            /// <summary>
            /// <para>The list of dedicated master node specifications supported in the current region.</para>
            /// </summary>
            [NameInMap("masterSpec")]
            [Validation(Required=false)]
            public List<string> MasterSpec { get; set; }

            /// <summary>
            /// <para>The node configuration.</para>
            /// </summary>
            [NameInMap("node")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultNode Node { get; set; }
            public class GetRegionConfigurationResponseBodyResultNode : TeaModel {
                /// <summary>
                /// <para>The maximum number of data nodes allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                /// <summary>
                /// <para>The minimum number of data nodes allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            /// <summary>
            /// <para>The list of data node specifications.</para>
            /// </summary>
            [NameInMap("nodeSpecList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultNodeSpecList> NodeSpecList { get; set; }
            public class GetRegionConfigurationResponseBodyResultNodeSpecList : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores for the specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("cpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// <para>The disk size for the specification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44000</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <para>The disk storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>Specifies whether the specification is available for purchase. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Available.</description></item>
                /// <item><description>false: Unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The memory size of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("memorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

                /// <summary>
                /// <para>The specification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>common: Cloud disk.</description></item>
                /// <item><description>local_efficiency: Local SATA disk.</description></item>
                /// <item><description>local_ssd: Local SSD.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local_efficiency</para>
                /// </summary>
                [NameInMap("specGroupType")]
                [Validation(Required=false)]
                public string SpecGroupType { get; set; }

            }

            /// <summary>
            /// <para>The current region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The supported version configurations.</para>
            /// </summary>
            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultSupportVersions> SupportVersions { get; set; }
            public class GetRegionConfigurationResponseBodyResultSupportVersions : TeaModel {
                /// <summary>
                /// <para>The instance category. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>advanced: Advanced Edition.</description></item>
                /// <item><description>x-pack: Commercial Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>x-pack</para>
                /// </summary>
                [NameInMap("instanceCategory")]
                [Validation(Required=false)]
                public string InstanceCategory { get; set; }

                /// <summary>
                /// <para>The supported Elasticsearch version information.</para>
                /// </summary>
                [NameInMap("supportVersionList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList> SupportVersionList { get; set; }
                public class GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList : TeaModel {
                    /// <summary>
                    /// <para>The version available for selection on the buy page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.5</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The detailed version number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.5.3</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The warm node configuration.</para>
            /// </summary>
            [NameInMap("warmNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultWarmNodeProperties WarmNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultWarmNodeProperties : TeaModel {
                /// <summary>
                /// <para>The range for the number of nodes.</para>
                /// </summary>
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultWarmNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultWarmNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                /// <summary>
                /// <para>The list of disk configurations.</para>
                /// </summary>
                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether disk encryption can be enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Supported.</description></item>
                    /// <item><description>false: Not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    /// <summary>
                    /// <para>The disk storage type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_efficiency</para>
                    /// </summary>
                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <para>The maximum value allowed for the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5120</para>
                    /// </summary>
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    /// <summary>
                    /// <para>The minimum value allowed for the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <para>The maximum value allowed for continuous disk sizing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("scaleLimit")]
                    [Validation(Required=false)]
                    public int? ScaleLimit { get; set; }

                    /// <summary>
                    /// <para>The list of allowed discrete values for the warm data node disk capacity.</para>
                    /// </summary>
                    [NameInMap("valueLimitSet")]
                    [Validation(Required=false)]
                    public List<string> ValueLimitSet { get; set; }

                }

                /// <summary>
                /// <para>The list of warm data node specifications supported in the current region.</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            /// <summary>
            /// <para>The list of zones supported in the current region.</para>
            /// </summary>
            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

    }

}
