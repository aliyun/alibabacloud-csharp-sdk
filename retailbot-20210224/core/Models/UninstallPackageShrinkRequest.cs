// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UninstallPackageShrinkRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string OperatorShrink { get; set; }

        /// <summary>
        /// 取消订阅的行业包
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public string PackagesShrink { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
