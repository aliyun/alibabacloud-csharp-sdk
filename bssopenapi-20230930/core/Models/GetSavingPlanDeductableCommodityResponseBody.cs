// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class GetSavingPlanDeductableCommodityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSavingPlanDeductableCommodityResponseBodyData> Data { get; set; }
        public class GetSavingPlanDeductableCommodityResponseBodyData : TeaModel {
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public long? ActivityId { get; set; }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityId")]
            [Validation(Required=false)]
            public long? CommodityId { get; set; }

            [NameInMap("CommodityName")]
            [Validation(Required=false)]
            public string CommodityName { get; set; }

            [NameInMap("CycleList")]
            [Validation(Required=false)]
            public List<GetSavingPlanDeductableCommodityResponseBodyDataCycleList> CycleList { get; set; }
            public class GetSavingPlanDeductableCommodityResponseBodyDataCycleList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("FilterModules")]
            [Validation(Required=false)]
            public List<GetSavingPlanDeductableCommodityResponseBodyDataFilterModules> FilterModules { get; set; }
            public class GetSavingPlanDeductableCommodityResponseBodyDataFilterModules : TeaModel {
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            [NameInMap("ItemCode")]
            [Validation(Required=false)]
            public string ItemCode { get; set; }

            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public long? ItemId { get; set; }

            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("ModuleMapList")]
            [Validation(Required=false)]
            public List<GetSavingPlanDeductableCommodityResponseBodyDataModuleMapList> ModuleMapList { get; set; }
            public class GetSavingPlanDeductableCommodityResponseBodyDataModuleMapList : TeaModel {
                [NameInMap("FilterModules")]
                [Validation(Required=false)]
                public List<GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListFilterModules> FilterModules { get; set; }
                public class GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListFilterModules : TeaModel {
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("ModuleId")]
                    [Validation(Required=false)]
                    public long? ModuleId { get; set; }

                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                }

                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("ShowModules")]
                [Validation(Required=false)]
                public List<GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListShowModules> ShowModules { get; set; }
                public class GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListShowModules : TeaModel {
                    [NameInMap("ModuleCode")]
                    [Validation(Required=false)]
                    public string ModuleCode { get; set; }

                    [NameInMap("ModuleId")]
                    [Validation(Required=false)]
                    public long? ModuleId { get; set; }

                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                }

                [NameInMap("SpnTypeList")]
                [Validation(Required=false)]
                public List<string> SpnTypeList { get; set; }

                [NameInMap("SpnTypeMapList")]
                [Validation(Required=false)]
                public List<Dictionary<string, DataModuleMapListSpnTypeMapListValue>> SpnTypeMapList { get; set; }

                [NameInMap("SpnTypeNameList")]
                [Validation(Required=false)]
                public List<GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListSpnTypeNameList> SpnTypeNameList { get; set; }
                public class GetSavingPlanDeductableCommodityResponseBodyDataModuleMapListSpnTypeNameList : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            [NameInMap("PayModeList")]
            [Validation(Required=false)]
            public List<GetSavingPlanDeductableCommodityResponseBodyDataPayModeList> PayModeList { get; set; }
            public class GetSavingPlanDeductableCommodityResponseBodyDataPayModeList : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("PricingModules")]
            [Validation(Required=false)]
            public List<GetSavingPlanDeductableCommodityResponseBodyDataPricingModules> PricingModules { get; set; }
            public class GetSavingPlanDeductableCommodityResponseBodyDataPricingModules : TeaModel {
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

            [NameInMap("SpnCommodityCode")]
            [Validation(Required=false)]
            public string SpnCommodityCode { get; set; }

            [NameInMap("SpnCommodityName")]
            [Validation(Required=false)]
            public string SpnCommodityName { get; set; }

            [NameInMap("SpnDiscountConfigType")]
            [Validation(Required=false)]
            public string SpnDiscountConfigType { get; set; }

            [NameInMap("StepPriceMap")]
            [Validation(Required=false)]
            public Dictionary<string, List<DataStepPriceMapValue>> StepPriceMap { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
