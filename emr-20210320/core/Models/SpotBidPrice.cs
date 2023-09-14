// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SpotBidPrice : TeaModel {
        /// <summary>
        /// 实例的每小时最高出价。支持最大3位小数，参数SpotStrategy=SpotWithPriceLimit时，该参数生效。
        /// </summary>
        [NameInMap("BidPrice")]
        [Validation(Required=false)]
        public double? BidPrice { get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
