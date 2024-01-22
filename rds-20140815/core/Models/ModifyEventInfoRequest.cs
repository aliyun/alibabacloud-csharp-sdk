// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyEventInfoRequest : TeaModel {
        /// <summary>
        /// The action parameter. Set this value in the JSON string format.
        /// </summary>
        [NameInMap("ActionParams")]
        [Validation(Required=false)]
        public string ActionParams { get; set; }

        /// <summary>
        /// The event handling action. Set this value to archive or undo.
        /// </summary>
        [NameInMap("EventAction")]
        [Validation(Required=false)]
        public string EventAction { get; set; }

        /// <summary>
        /// The event ID. Separate multiple event IDs with commas (,). You can configure up to 20 event IDs.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
