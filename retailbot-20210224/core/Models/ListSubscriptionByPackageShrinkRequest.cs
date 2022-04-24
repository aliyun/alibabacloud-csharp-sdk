// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListSubscriptionByPackageShrinkRequest : TeaModel {
        /// <summary>
        /// 行业包信息
        /// </summary>
        [NameInMap("PackageDTO")]
        [Validation(Required=false)]
        public string PackageDTOShrink { get; set; }

        /// <summary>
        /// 分页参数
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public string PageDataShrink { get; set; }

    }

}
