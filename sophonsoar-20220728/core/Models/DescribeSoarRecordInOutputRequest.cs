// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordInOutputRequest : TeaModel {
        /// <summary>
        /// The UUID of the component action.
        /// 
        /// >  You can call the [DescribeSoarTaskAndActions](~~DescribeSoarTaskAndActions~~) operation to query the UUIDs of component actions.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionUuid")]
        [Validation(Required=false)]
        public string ActionUuid { get; set; }

        /// <summary>
        /// The language of the content within the request and the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
