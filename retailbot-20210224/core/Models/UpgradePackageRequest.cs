// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UpgradePackageRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public UpgradePackageRequestOperator Operator { get; set; }
        public class UpgradePackageRequestOperator : TeaModel {
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
        };

        /// <summary>
        /// 需要升级的行业包
        /// </summary>
        [NameInMap("PackageDTO")]
        [Validation(Required=false)]
        public UpgradePackageRequestPackageDTO PackageDTO { get; set; }
        public class UpgradePackageRequestPackageDTO : TeaModel {
            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }
        };

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCodes")]
        [Validation(Required=false)]
        public List<string> RobotCodes { get; set; }

    }

}
