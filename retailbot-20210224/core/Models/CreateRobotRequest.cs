// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class CreateRobotRequest : TeaModel {
        /// <summary>
        /// 操作人信息
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public CreateRobotRequestOperator Operator { get; set; }
        public class CreateRobotRequestOperator : TeaModel {
            [NameInMap("OperatorId")]
            [Validation(Required=false)]
            public string OperatorId { get; set; }
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }
        };

        /// <summary>
        /// 机器人信息
        /// </summary>
        [NameInMap("RobotDTO")]
        [Validation(Required=false)]
        public CreateRobotRequestRobotDTO RobotDTO { get; set; }
        public class CreateRobotRequestRobotDTO : TeaModel {
            [NameInMap("Channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public long? ExpireDate { get; set; }
            [NameInMap("RobotType")]
            [Validation(Required=false)]
            public string RobotType { get; set; }
            [NameInMap("SellerId")]
            [Validation(Required=false)]
            public string SellerId { get; set; }
            [NameInMap("SellerNick")]
            [Validation(Required=false)]
            public string SellerNick { get; set; }
            [NameInMap("ShopId")]
            [Validation(Required=false)]
            public string ShopId { get; set; }
            [NameInMap("SignDate")]
            [Validation(Required=false)]
            public long? SignDate { get; set; }
        };

    }

}
