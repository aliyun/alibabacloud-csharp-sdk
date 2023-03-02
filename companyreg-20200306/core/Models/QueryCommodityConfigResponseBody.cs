// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class QueryCommodityConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCommodityConfigResponseBodyData Data { get; set; }
        public class QueryCommodityConfigResponseBodyData : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("CommodityModules")]
            [Validation(Required=false)]
            public List<QueryCommodityConfigResponseBodyDataCommodityModules> CommodityModules { get; set; }
            public class QueryCommodityConfigResponseBodyDataCommodityModules : TeaModel {
                [NameInMap("LxModuleCode")]
                [Validation(Required=false)]
                public string LxModuleCode { get; set; }

                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleDescription")]
                [Validation(Required=false)]
                public string ModuleDescription { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("ModuleTip")]
                [Validation(Required=false)]
                public string ModuleTip { get; set; }

                [NameInMap("ModuleType")]
                [Validation(Required=false)]
                public string ModuleType { get; set; }

                [NameInMap("ModuleUrl")]
                [Validation(Required=false)]
                public string ModuleUrl { get; set; }

                [NameInMap("ModuleValue")]
                [Validation(Required=false)]
                public string ModuleValue { get; set; }

                [NameInMap("SortNumber")]
                [Validation(Required=false)]
                public int? SortNumber { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("ProductLine")]
            [Validation(Required=false)]
            public string ProductLine { get; set; }

            [NameInMap("ProtocolUrl")]
            [Validation(Required=false)]
            public string ProtocolUrl { get; set; }

            [NameInMap("StartingPrice")]
            [Validation(Required=false)]
            public string StartingPrice { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
