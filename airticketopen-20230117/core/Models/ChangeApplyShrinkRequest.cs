// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeApplyShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("change_passenger_list")]
        [Validation(Required=false)]
        public string ChangePassengerListShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("changed_journeys")]
        [Validation(Required=false)]
        public string ChangedJourneysShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order_num")]
        [Validation(Required=false)]
        public long? OrderNum { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
