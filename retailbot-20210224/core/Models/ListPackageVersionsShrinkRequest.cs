// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListPackageVersionsShrinkRequest : TeaModel {
        /// <summary>
        /// 操作人id
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        /// <summary>
        /// 包code集合
        /// </summary>
        [NameInMap("PackageCodes")]
        [Validation(Required=false)]
        public string PackageCodesShrink { get; set; }

    }

}
