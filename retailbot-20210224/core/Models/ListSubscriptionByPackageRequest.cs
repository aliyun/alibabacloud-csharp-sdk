// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListSubscriptionByPackageRequest : TeaModel {
        /// <summary>
        /// 行业包信息
        /// </summary>
        [NameInMap("PackageDTO")]
        [Validation(Required=false)]
        public ListSubscriptionByPackageRequestPackageDTO PackageDTO { get; set; }
        public class ListSubscriptionByPackageRequestPackageDTO : TeaModel {
            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }
        };

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public ListSubscriptionByPackageRequestPageData PageData { get; set; }
        public class ListSubscriptionByPackageRequestPageData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
