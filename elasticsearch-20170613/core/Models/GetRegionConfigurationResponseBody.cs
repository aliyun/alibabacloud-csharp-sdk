// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetRegionConfigurationResponseBody : TeaModel {
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
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }
            [NameInMap("clientNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultClientNodeDiskList> ClientNodeDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultClientNodeDiskList : TeaModel {
                public string DiskType { get; set; }
                public int? MaxSize { get; set; }
                public int? MinSize { get; set; }
                public int? ScaleLimit { get; set; }
            }
            [NameInMap("clientNodeSpec")]
            [Validation(Required=false)]
            public List<string> ClientNodeSpec { get; set; }
            [NameInMap("createUrl")]
            [Validation(Required=false)]
            public string CreateUrl { get; set; }
            [NameInMap("dataDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultDataDiskList> DataDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultDataDiskList : TeaModel {
                public string DiskType { get; set; }
                public int? MaxSize { get; set; }
                public int? MinSize { get; set; }
                public int? ScaleLimit { get; set; }
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
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }
                };

                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultElasticNodePropertiesDiskList : TeaModel {
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

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
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("instanceSupportNodes")]
            [Validation(Required=false)]
            public List<string> InstanceSupportNodes { get; set; }
            [NameInMap("jvmConfine")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultJvmConfine JvmConfine { get; set; }
            public class GetRegionConfigurationResponseBodyResultJvmConfine : TeaModel {
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
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }
                };

                [NameInMap("spec")]
                [Validation(Required=false)]
                public List<string> Spec { get; set; }

            }
            [NameInMap("masterDiskList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultMasterDiskList> MasterDiskList { get; set; }
            public class GetRegionConfigurationResponseBodyResultMasterDiskList : TeaModel {
                public string DiskType { get; set; }
                public int? MaxSize { get; set; }
                public int? MinSize { get; set; }
                public int? ScaleLimit { get; set; }
            }
            [NameInMap("masterSpec")]
            [Validation(Required=false)]
            public List<string> MasterSpec { get; set; }
            [NameInMap("node")]
            [Validation(Required=false)]
            public GetRegionConfigurationResponseBodyResultNode Node { get; set; }
            public class GetRegionConfigurationResponseBodyResultNode : TeaModel {
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }
            [NameInMap("nodeSpecList")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultNodeSpecList> NodeSpecList { get; set; }
            public class GetRegionConfigurationResponseBodyResultNodeSpecList : TeaModel {
                public int? CpuCount { get; set; }
                public int? Disk { get; set; }
                public string DiskType { get; set; }
                public bool? Enable { get; set; }
                public int? MemorySize { get; set; }
                public string Spec { get; set; }
                public string SpecGroupType { get; set; }
            }
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<GetRegionConfigurationResponseBodyResultSupportVersions> SupportVersions { get; set; }
            public class GetRegionConfigurationResponseBodyResultSupportVersions : TeaModel {
                public string InstanceCategory { get; set; }
                public List<GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList> SupportVersionList { get; set; }
                public class GetRegionConfigurationResponseBodyResultSupportVersionsSupportVersionList : TeaModel {
                    public string Key { get; set; }
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
                    [NameInMap("maxAmount")]
                    [Validation(Required=false)]
                    public int? MaxAmount { get; set; }
                    [NameInMap("minAmount")]
                    [Validation(Required=false)]
                    public int? MinAmount { get; set; }
                };

                [NameInMap("diskList")]
                [Validation(Required=false)]
                public List<GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList> DiskList { get; set; }
                public class GetRegionConfigurationResponseBodyResultWarmNodePropertiesDiskList : TeaModel {
                    [NameInMap("diskEncryption")]
                    [Validation(Required=false)]
                    public bool? DiskEncryption { get; set; }

                    [NameInMap("diskType")]
                    [Validation(Required=false)]
                    public string DiskType { get; set; }

                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

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
        };

    }

}
