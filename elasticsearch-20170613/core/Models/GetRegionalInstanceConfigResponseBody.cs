// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetRegionalInstanceConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetRegionalInstanceConfigResponseBodyResult Result { get; set; }
        public class GetRegionalInstanceConfigResponseBodyResult : TeaModel {
            [NameInMap("clientNodeAmountRange")]
            [Validation(Required=false)]
            public GetRegionalInstanceConfigResponseBodyResultClientNodeAmountRange ClientNodeAmountRange { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultClientNodeAmountRange : TeaModel {
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            [NameInMap("clientNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionalInstanceConfigResponseBodyResultClientNodeDiskList> ClientNodeDiskList { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultClientNodeDiskList : TeaModel {
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

            }

            [NameInMap("clientSpecs")]
            [Validation(Required=false)]
            public List<string> ClientSpecs { get; set; }

            [NameInMap("dataNodeAmountRange")]
            [Validation(Required=false)]
            public GetRegionalInstanceConfigResponseBodyResultDataNodeAmountRange DataNodeAmountRange { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultDataNodeAmountRange : TeaModel {
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            [NameInMap("dataNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionalInstanceConfigResponseBodyResultDataNodeDiskList> DataNodeDiskList { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultDataNodeDiskList : TeaModel {
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

                [NameInMap("subClassificationConfines")]
                [Validation(Required=false)]
                public List<GetRegionalInstanceConfigResponseBodyResultDataNodeDiskListSubClassificationConfines> SubClassificationConfines { get; set; }
                public class GetRegionalInstanceConfigResponseBodyResultDataNodeDiskListSubClassificationConfines : TeaModel {
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    [NameInMap("performanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                }

                [NameInMap("valueLimitSet")]
                [Validation(Required=false)]
                public List<int?> ValueLimitSet { get; set; }

            }

            [NameInMap("dataNodeSpecs")]
            [Validation(Required=false)]
            public List<string> DataNodeSpecs { get; set; }

            [NameInMap("kibanaSpecs")]
            [Validation(Required=false)]
            public List<string> KibanaSpecs { get; set; }

            [NameInMap("masterAmountRange")]
            [Validation(Required=false)]
            public List<string> MasterAmountRange { get; set; }

            [NameInMap("masterDiskList")]
            [Validation(Required=false)]
            public List<GetRegionalInstanceConfigResponseBodyResultMasterDiskList> MasterDiskList { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultMasterDiskList : TeaModel {
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

                [NameInMap("subClassificationConfines")]
                [Validation(Required=false)]
                public List<GetRegionalInstanceConfigResponseBodyResultMasterDiskListSubClassificationConfines> SubClassificationConfines { get; set; }
                public class GetRegionalInstanceConfigResponseBodyResultMasterDiskListSubClassificationConfines : TeaModel {
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    [NameInMap("performanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                }

            }

            [NameInMap("masterSpecs")]
            [Validation(Required=false)]
            public List<string> MasterSpecs { get; set; }

            [NameInMap("specInfoMap")]
            [Validation(Required=false)]
            public Dictionary<string, ResultSpecInfoMapValue> SpecInfoMap { get; set; }

            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

            [NameInMap("warmNodeAmountRange")]
            [Validation(Required=false)]
            public GetRegionalInstanceConfigResponseBodyResultWarmNodeAmountRange WarmNodeAmountRange { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultWarmNodeAmountRange : TeaModel {
                [NameInMap("maxAmount")]
                [Validation(Required=false)]
                public int? MaxAmount { get; set; }

                [NameInMap("minAmount")]
                [Validation(Required=false)]
                public int? MinAmount { get; set; }

            }

            [NameInMap("warmNodeDiskList")]
            [Validation(Required=false)]
            public List<GetRegionalInstanceConfigResponseBodyResultWarmNodeDiskList> WarmNodeDiskList { get; set; }
            public class GetRegionalInstanceConfigResponseBodyResultWarmNodeDiskList : TeaModel {
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

                [NameInMap("subClassificationConfines")]
                [Validation(Required=false)]
                public List<GetRegionalInstanceConfigResponseBodyResultWarmNodeDiskListSubClassificationConfines> SubClassificationConfines { get; set; }
                public class GetRegionalInstanceConfigResponseBodyResultWarmNodeDiskListSubClassificationConfines : TeaModel {
                    [NameInMap("maxSize")]
                    [Validation(Required=false)]
                    public int? MaxSize { get; set; }

                    [NameInMap("minSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                    [NameInMap("performanceLevel")]
                    [Validation(Required=false)]
                    public string PerformanceLevel { get; set; }

                }

                [NameInMap("valueLimitSet")]
                [Validation(Required=false)]
                public List<int?> ValueLimitSet { get; set; }

            }

            [NameInMap("warmNodeSpecs")]
            [Validation(Required=false)]
            public List<string> WarmNodeSpecs { get; set; }

        }

    }

}
