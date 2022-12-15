// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class LingJieOpenStatus : TeaModel {
        [NameInMap("CommoditiesOpenStatus")]
        [Validation(Required=false)]
        public List<LingJieOpenStatusCommoditiesOpenStatus> CommoditiesOpenStatus { get; set; }
        public class LingJieOpenStatusCommoditiesOpenStatus : TeaModel {
            [NameInMap("CnName")]
            [Validation(Required=false)]
            public string CnName { get; set; }

            [NameInMap("Commodity")]
            [Validation(Required=false)]
            public string Commodity { get; set; }

            [NameInMap("Describe")]
            [Validation(Required=false)]
            public string Describe { get; set; }

            [NameInMap("DetailPage")]
            [Validation(Required=false)]
            public string DetailPage { get; set; }

            [NameInMap("Open")]
            [Validation(Required=false)]
            public bool? Open { get; set; }

            [NameInMap("OpenTime")]
            [Validation(Required=false)]
            public string OpenTime { get; set; }

        }

        [NameInMap("OpenTime")]
        [Validation(Required=false)]
        public string OpenTime { get; set; }

        [NameInMap("ProductConsoleUrl")]
        [Validation(Required=false)]
        public string ProductConsoleUrl { get; set; }

        [NameInMap("ProductEnabled")]
        [Validation(Required=false)]
        public bool? ProductEnabled { get; set; }

        [NameInMap("ProductMonitorUrl")]
        [Validation(Required=false)]
        public string ProductMonitorUrl { get; set; }

        [NameInMap("ProductWikiUrl")]
        [Validation(Required=false)]
        public string ProductWikiUrl { get; set; }

    }

}
