// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeMyBaseInstanceOverViewResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public DescribeMyBaseInstanceOverViewResponseBodyRegions Regions { get; set; }
        public class DescribeMyBaseInstanceOverViewResponseBodyRegions : TeaModel {
            [NameInMap("RegionModel")]
            [Validation(Required=false)]
            public List<DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModel> RegionModel { get; set; }
            public class DescribeMyBaseInstanceOverViewResponseBodyRegionsRegionModel : TeaModel {
                [NameInMap("EngineCount")]
                [Validation(Required=false)]
                public string EngineCount { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TypeModels")]
                [Validation(Required=false)]
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
                                [NameInMap("CreatedTime")]
                                [Validation(Required=false)]
                                public string CreatedTime { get; set; }

                                [NameInMap("DBInstanceId")]
                                [Validation(Required=false)]
                                public string DBInstanceId { get; set; }

                                [NameInMap("DBInstanceStatus")]
                                [Validation(Required=false)]
                                public string DBInstanceStatus { get; set; }

                                [NameInMap("ExpireTime")]
                                [Validation(Required=false)]
                                public string ExpireTime { get; set; }

                                [NameInMap("PayType")]
                                [Validation(Required=false)]
                                public string PayType { get; set; }

                                [NameInMap("ZoneId")]
                                [Validation(Required=false)]
                                public string ZoneId { get; set; }

                            }

                        }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
