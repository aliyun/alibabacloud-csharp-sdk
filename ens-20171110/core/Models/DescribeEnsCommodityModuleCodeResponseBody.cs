// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsCommodityModuleCodeResponseBody : TeaModel {
        [NameInMap("CommodityCodesInfo")]
        [Validation(Required=false)]
        public List<DescribeEnsCommodityModuleCodeResponseBodyCommodityCodesInfo> CommodityCodesInfo { get; set; }
        public class DescribeEnsCommodityModuleCodeResponseBodyCommodityCodesInfo : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("ModuleCodesInfo")]
            [Validation(Required=false)]
            public List<DescribeEnsCommodityModuleCodeResponseBodyCommodityCodesInfoModuleCodesInfo> ModuleCodesInfo { get; set; }
            public class DescribeEnsCommodityModuleCodeResponseBodyCommodityCodesInfoModuleCodesInfo : TeaModel {
                [NameInMap("ModuleCode")]
                [Validation(Required=false)]
                public string ModuleCode { get; set; }

                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
