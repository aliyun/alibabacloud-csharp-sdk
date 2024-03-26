// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class SaveActivityShrinkRequest : TeaModel {
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BlackUidList")]
        [Validation(Required=false)]
        public List<long?> BlackUidList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("ExtendMap")]
        [Validation(Required=false)]
        public string ExtendMapShrink { get; set; }

        [NameInMap("FusionPromotionParamList")]
        [Validation(Required=false)]
        public List<SaveActivityShrinkRequestFusionPromotionParamList> FusionPromotionParamList { get; set; }
        public class SaveActivityShrinkRequestFusionPromotionParamList : TeaModel {
            [NameInMap("CommodityCodeList")]
            [Validation(Required=false)]
            public List<string> CommodityCodeList { get; set; }

            [NameInMap("PromotionValue")]
            [Validation(Required=false)]
            public double? PromotionValue { get; set; }

            [NameInMap("RestrictedRegionList")]
            [Validation(Required=false)]
            public List<string> RestrictedRegionList { get; set; }

            [NameInMap("moduleInfoParamList")]
            [Validation(Required=false)]
            public List<SaveActivityShrinkRequestFusionPromotionParamListModuleInfoParamList> ModuleInfoParamList { get; set; }
            public class SaveActivityShrinkRequestFusionPromotionParamListModuleInfoParamList : TeaModel {
                [NameInMap("componentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("itemCode")]
                [Validation(Required=false)]
                public string ItemCode { get; set; }

                [NameInMap("moduleId")]
                [Validation(Required=false)]
                public long? ModuleId { get; set; }

                [NameInMap("moduleKey")]
                [Validation(Required=false)]
                public string ModuleKey { get; set; }

                [NameInMap("moduleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("moduleValueList")]
                [Validation(Required=false)]
                public List<string> ModuleValueList { get; set; }

                [NameInMap("pricePlanId")]
                [Validation(Required=false)]
                public long? PricePlanId { get; set; }

            }

        }

        [NameInMap("PublishTag")]
        [Validation(Required=false)]
        public string PublishTag { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TestAccountUidList")]
        [Validation(Required=false)]
        public List<long?> TestAccountUidList { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("WhiteUidList")]
        [Validation(Required=false)]
        public List<long?> WhiteUidList { get; set; }

    }

}
