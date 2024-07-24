// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ClaimAlarmRequest : TeaModel {
        /// <summary>
        /// The alert ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlarmId")]
        [Validation(Required=false)]
        public long? AlarmId { get; set; }

        /// <summary>
        /// The ID of the handler.
        /// </summary>
        [NameInMap("HandlerId")]
        [Validation(Required=false)]
        public long? HandlerId { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
