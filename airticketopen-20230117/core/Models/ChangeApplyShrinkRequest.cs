// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyShrinkRequest : TeaModel {
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public string ChangePassengerListShrink { get; set; }

        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public string ChangedJourneysShrink { get; set; }

        [NameInMap("contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
