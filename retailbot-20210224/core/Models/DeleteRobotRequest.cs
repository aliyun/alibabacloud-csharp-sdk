// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class DeleteRobotRequest : TeaModel {
        /// <summary>
        /// 备注信息
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public DeleteRobotRequestOperator Operator { get; set; }
        public class DeleteRobotRequestOperator : TeaModel {
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
        };

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
