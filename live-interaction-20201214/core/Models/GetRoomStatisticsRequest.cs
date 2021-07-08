// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetRoomStatisticsRequest : TeaModel {
        /// <summary>
        /// 请求参数的结构体。
        /// </summary>
        [NameInMap("Request")]
        [Validation(Required=false)]
        public GetRoomStatisticsRequestRequest Request { get; set; }
        public class GetRoomStatisticsRequestRequest : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }
            [NameInMap("RoomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }
        };

    }

}
