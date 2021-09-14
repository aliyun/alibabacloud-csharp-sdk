// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeMyBaseHostOverViewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMyBaseHostOverViewResponseBodyRegions Regions { get; set; }
        public class DescribeMyBaseHostOverViewResponseBodyRegions : TeaModel {
            [NameInMap("RegionModel")]
            [Validation(Required=false)]
            public List<DescribeMyBaseHostOverViewResponseBodyRegionsRegionModel> RegionModel { get; set; }
            public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModel : TeaModel {
                public string EngineCount { get; set; }
                public int? TotalCount { get; set; }
                public int? HostGroupCount { get; set; }
                public string Region { get; set; }
                public DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModels TypeModels { get; set; }
                public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModels : TeaModel {
                    [NameInMap("TypeModel")]
                    [Validation(Required=false)]
                    public List<DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel> TypeModel { get; set; }
                    public class DescribeMyBaseHostOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel : TeaModel {
                        [NameInMap("HostEngineCount")]
                        [Validation(Required=false)]
                        public string HostEngineCount { get; set; }

                        [NameInMap("HostDateType")]
                        [Validation(Required=false)]
                        public string HostDateType { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                    }

                }
            }
        };

    }

}
