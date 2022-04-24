// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UpgradePackageShrinkRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string OperatorShrink { get; set; }

        /// <summary>
        /// 需要升级的行业包
        /// </summary>
        [NameInMap("PackageDTO")]
        [Validation(Required=false)]
        public string PackageDTOShrink { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCodes")]
        [Validation(Required=false)]
        public string RobotCodesShrink { get; set; }

    }

}
