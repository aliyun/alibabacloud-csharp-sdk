// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmLockSeatRequest : TeaModel {
        [NameInMap("ExtUserId")]
        [Validation(Required=false)]
        public string ExtUserId { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("ParamsJson")]
        [Validation(Required=false)]
        public string ParamsJson { get; set; }

        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public long? ScheduleId { get; set; }

        [NameInMap("SeatIds")]
        [Validation(Required=false)]
        public string SeatIds { get; set; }

        [NameInMap("SeatNames")]
        [Validation(Required=false)]
        public string SeatNames { get; set; }

    }

}
