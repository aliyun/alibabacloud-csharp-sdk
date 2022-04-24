// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UpdateRobotShrinkRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string OperatorShrink { get; set; }

        /// <summary>
        /// 机器人信息
        /// </summary>
        [NameInMap("RobotDTO")]
        [Validation(Required=false)]
        public string RobotDTOShrink { get; set; }

    }

}
