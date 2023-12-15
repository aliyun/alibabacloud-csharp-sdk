// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AppMallsService20180224.Models
{
    public class TaobaoFilmGetSeatsRequest : TeaModel {
        [NameInMap("ParamsJson")]
        [Validation(Required=false)]
        public string ParamsJson { get; set; }

        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public long? ScheduleId { get; set; }

    }

}
