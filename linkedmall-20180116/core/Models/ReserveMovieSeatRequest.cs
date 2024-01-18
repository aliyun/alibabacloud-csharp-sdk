// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ReserveMovieSeatRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizUid")]
        [Validation(Required=false)]
        public string BizUid { get; set; }

        [NameInMap("ExtJson")]
        [Validation(Required=false)]
        public string ExtJson { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

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
