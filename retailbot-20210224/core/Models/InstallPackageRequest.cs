// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class InstallPackageRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public InstallPackageRequestOperator Operator { get; set; }
        public class InstallPackageRequestOperator : TeaModel {
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
        };

        /// <summary>
        /// 订阅的行业包
        /// </summary>
        [NameInMap("Packages")]
        [Validation(Required=false)]
        public List<InstallPackageRequestPackages> Packages { get; set; }
        public class InstallPackageRequestPackages : TeaModel {
            /// <summary>
            /// 行业包code
            /// </summary>
            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }

            /// <summary>
            /// 行业包版本
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

        }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
