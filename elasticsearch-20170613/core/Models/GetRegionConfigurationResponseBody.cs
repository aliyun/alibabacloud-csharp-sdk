// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetRegionConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRegionConfigurationResponseBodyResult Result { get; set; }
        public class GetRegionConfigurationResponseBodyResult : TeaModel {
            [NameInMap("clientNodeAmountRange")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultClientNodeAmountRange ClientNodeAmountRange { get; set; }
            public class GetRegionConfigurationResponseBodyResultClientNodeAmountRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            [NameInMap("clientNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultClientNodeDiskList> ClientNodeDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultClientNodeDiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

            }

            [NameInMap("clientNodeSpec")]
            [Validation(Required=false)]
            public List<string> ClientNodeSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://common-buy.aliyun.com/?commodityCode=elasticsearch&orderType=BUY#/buy">https://common-buy.aliyun.com/?commodityCode=elasticsearch&amp;orderType=BUY#/buy</a></para>
            /// </summary>
            [NameInMap("createUrl")]
            [Validation(Required=false)]
            public string CreateUrl { get; set; }

            [NameInMap("dataDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultDataDiskList> DataDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultDataDiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5120</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

                [NameInMap("valueLimitSet")]
                [Validation(Required=false)]
                public List<string> ValueLimitSet { get; set; }

            }

            [NameInMap("elasticNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultElasticNodeProperties ElasticNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultElasticNodeProperties : TeaModel {
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultElasticNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultElasticNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_ssd</para>
                    /// </summary>
                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5120</para>
                    /// </summary>
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("scaleLimit")]
                    [Validation(Required=false)]
                    public int? ScaleLimit { get; set; }

                    [NameInMap("valueLimitSet")]
                    [Validation(Required=false)]
                    public List<string> ValueLimitSet { get; set; }

                }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>production</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            [NameInMap("esVersions")]
            [Validation(Required=false)]
            public List<string> EsVersions { get; set; }

            [NameInMap("esVersionsLatestList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultEsVersionsLatestList> EsVersionsLatestList { get; set; }
            public class GetRegionConfigurationResponseBodyResultEsVersionsLatestList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5.5_with_X-Pack</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.5.3_with_X-Pack</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("instanceSupportNodes")]
            [Validation(Required=false)]
            public List<string> InstanceSupportNodes { get; set; }

            [NameInMap("jvmConfine")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultJvmConfine JvmConfine { get; set; }
            public class GetRegionConfigurationResponseBodyResultJvmConfine : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                [NameInMap("supportEsVersions")]
                [Validation(Required=false)]
                public List<string> SupportEsVersions { get; set; }

                [NameInMap("supportGcs")]
                [Validation(Required=false)]
                public List<string> SupportGcs { get; set; }

            }

            [NameInMap("kibanaNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultKibanaNodeProperties KibanaNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultKibanaNodeProperties : TeaModel {
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultKibanaNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultKibanaNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            [NameInMap("logstashZones")]
            [Validation(Required=false)]
            public List<string> LogstashZones { get; set; }

            [NameInMap("masterDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultMasterDiskList> MasterDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultMasterDiskList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxSize")]
                [Validation(Required=false)]
                public int? MaxSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("minSize")]
                [Validation(Required=false)]
                public int? MinSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("scaleLimit")]
                [Validation(Required=false)]
                public int? ScaleLimit { get; set; }

            }

            [NameInMap("masterSpec")]
            [Validation(Required=false)]
            public List<string> MasterSpec { get; set; }

            [NameInMap("node")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultNode Node { get; set; }
            public class GetRegionConfigurationResponseBodyResultNode : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            [NameInMap("nodeSpecList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultNodeSpecList> NodeSpecList { get; set; }
            public class GetRegionConfigurationResponseBodyResultNodeSpecList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("cpuCount")]
                [Validation(Required=false)]
                public int? CpuCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>44000</para>
                /// </summary>
                [NameInMap("disk")]
                [Validation(Required=false)]
                public int? Disk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>local_efficiency</para>
                /// </summary>
                [NameInMap("diskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("memorySize")]
                [Validation(Required=false)]
                public int? MemorySize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>elasticsearch.sn2ne.large</para>
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>local_efficiency</para>
                /// </summary>
                [NameInMap("specGroupType")]
                [Validation(Required=false)]
                public string SpecGroupType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultSupportVersions> SupportVersions { get; set; }
            public class GetRegionConfigurationResponseBodyResultSupportVersions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>x-pack</para>
                /// </summary>
                [NameInMap("instanceCategory")]
                [Validation(Required=false)]
                public string InstanceCategory { get; set; }

                [NameInMap("supportVersionList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList> SupportVersionList { get; set; }
                public class GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5.5</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5.5.3</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("warmNodeProperties")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultWarmNodeProperties WarmNodeProperties { get; set; }
            public class GetRegionConfigurationResponseBodyResultWarmNodeProperties : TeaModel {
                [NameInMap("amountRange")]
                [Validation(Required=false)]
                public GetRegionConfigurationResponseBodyResultWarmNodePropertiesAmountRange AmountRange { get; set; }
                public class GetRegionConfigurationResponseBodyResultWarmNodePropertiesAmountRange : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }

                }

                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_efficiency</para>
                    /// </summary>
                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5120</para>
                    /// </summary>
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2048</para>
                    /// </summary>
                    [NameInMap("scaleLimit")]
                    [Validation(Required=false)]
                    public int? ScaleLimit { get; set; }

                    [NameInMap("valueLimitSet")]
                    [Validation(Required=false)]
                    public List<string> ValueLimitSet { get; set; }

                }

                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }

            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

    }

}
