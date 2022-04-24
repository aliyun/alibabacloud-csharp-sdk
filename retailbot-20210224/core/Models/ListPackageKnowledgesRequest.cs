// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListPackageKnowledgesRequest : TeaModel {
        /// <summary>
        /// 操作用户id
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作用户名称
        /// </summary>
        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        /// <summary>
        /// 包code
        /// </summary>
        [NameInMap("PackageCode")]
        [Validation(Required=false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// 包version
        /// </summary>
        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

    }

}
