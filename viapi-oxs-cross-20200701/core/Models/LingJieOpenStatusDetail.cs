// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class LingJieOpenStatusDetail : TeaModel {
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<LingJieOpenStatusDetailApiList> ApiList { get; set; }
        public class LingJieOpenStatusDetailApiList : TeaModel {
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            [NameInMap("ConcurrentLimit")]
            [Validation(Required=false)]
            public string ConcurrentLimit { get; set; }

            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("MoreOperations")]
            [Validation(Required=false)]
            public List<LingJieOpenStatusDetailApiListMoreOperations> MoreOperations { get; set; }
            public class LingJieOpenStatusDetailApiListMoreOperations : TeaModel {
                [NameInMap("ClickUrl")]
                [Validation(Required=false)]
                public string ClickUrl { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public string Operation { get; set; }

            }

            [NameInMap("StatisticsUnit")]
            [Validation(Required=false)]
            public string StatisticsUnit { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        [NameInMap("CommodityConcurrentLimitTips")]
        [Validation(Required=false)]
        public string CommodityConcurrentLimitTips { get; set; }

        [NameInMap("CommodityHasOpen")]
        [Validation(Required=false)]
        public bool? CommodityHasOpen { get; set; }

        [NameInMap("CommodityOpenUrl")]
        [Validation(Required=false)]
        public string CommodityOpenUrl { get; set; }

        [NameInMap("CommodityUsageTips")]
        [Validation(Required=false)]
        public string CommodityUsageTips { get; set; }

        [NameInMap("UserStopMode")]
        [Validation(Required=false)]
        public bool? UserStopMode { get; set; }

    }

}
