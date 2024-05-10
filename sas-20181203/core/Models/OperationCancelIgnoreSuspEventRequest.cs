// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationCancelIgnoreSuspEventRequest : TeaModel {
        /// <summary>
        /// The remarks.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The IDs of alert events.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<long?> SecurityEventIds { get; set; }

    }

}
