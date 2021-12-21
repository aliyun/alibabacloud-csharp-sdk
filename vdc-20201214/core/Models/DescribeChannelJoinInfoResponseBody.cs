// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelJoinInfoResponseBody : TeaModel {
        /// <summary>
        /// 在入会慢时间阈值内的入会成功率
        /// </summary>
        [NameInMap("JoinFastSuccessRate")]
        [Validation(Required=false)]
        public string JoinFastSuccessRate { get; set; }

        /// <summary>
        /// 入会慢时间阈值
        /// </summary>
        [NameInMap("JoinSlowThreshold")]
        [Validation(Required=false)]
        public long? JoinSlowThreshold { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
