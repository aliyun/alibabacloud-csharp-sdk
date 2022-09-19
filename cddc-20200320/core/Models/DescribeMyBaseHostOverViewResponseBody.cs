// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeMyBaseHostOverViewResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMyBaseHostOverViewResponseBodyRegions Regions { get; set; }
        public class DescribeMyBaseHostOverViewResponseBodyRegions : TeaModel {
            [NameInMap("RegionModel")]
            [Validation(Required=false)]
            public List<DescribeMyBaseHostOverViewResponseBodyRegionsRegionModel> RegionModel { get; set; }
            public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModel : TeaModel {
                [NameInMap("EngineCount")]
                [Validation(Required=false)]
                public string EngineCount { get; set; }

                [NameInMap("HostGroupCount")]
                [Validation(Required=false)]
                public int? HostGroupCount { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TypeModels")]
                [Validation(Required=false)]
                public DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModels TypeModels { get; set; }
                public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModels : TeaModel {
                    [NameInMap("TypeModel")]
                    [Validation(Required=false)]
                    public List<DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel> TypeModel { get; set; }
                    public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        [NameInMap("HostDateType")]
                        [Validation(Required=false)]
                        public string HostDateType { get; set; }

                        [NameInMap("HostEngineCount")]
                        [Validation(Required=false)]
                        public string HostEngineCount { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
