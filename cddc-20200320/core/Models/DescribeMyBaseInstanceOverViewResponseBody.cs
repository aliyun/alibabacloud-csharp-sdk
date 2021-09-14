// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeMyBaseInstanceOverViewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMyBaseInstanceOverViewResponseBodyRegions Regions { get; set; }
        public class DescribeMyBaseInstanceOverViewResponseBodyRegions : TeaModel {
            [NameInMap("RegionModel")]
            [Validation(Required=false)]
            public List<DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModel> RegionModel { get; set; }
            public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModel : TeaModel {
                public string EngineCount { get; set; }
                public int? TotalCount { get; set; }
                public string Region { get; set; }
                public DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModels TypeModels { get; set; }
                public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModels : TeaModel {
                    [NameInMap("TypeModel")]
                    [Validation(Required=false)]
                    public List<DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel> TypeModel { get; set; }
                    public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModel : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        [NameInMap("InstanceDateType")]
                        [Validation(Required=false)]
                        public string InstanceDateType { get; set; }

                        [NameInMap("InstanceEngineCount")]
                        [Validation(Required=false)]
                        public string InstanceEngineCount { get; set; }

                        [NameInMap("InstanceModels")]
                        [Validation(Required=false)]
                        public DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModelInstanceModels InstanceModels { get; set; }
                        public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModelInstanceModels : TeaModel {
                            [NameInMap("InstanceModel")]
                            [Validation(Required=false)]
                            public List<DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModelInstanceModelsInstanceModel> InstanceModel { get; set; }
                            public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModelTypeModelsTypeModelInstanceModelsInstanceModel : TeaModel {
                                public string ExpireTime { get; set; }
                                public string PayType { get; set; }
                                public string ZoneId { get; set; }
                                public string DBInstanceId { get; set; }
                                public string DBInstanceStatus { get; set; }
                                public string CreatedTime { get; set; }
                            }
                        };

                    }

                }
            }
        };

    }

}
