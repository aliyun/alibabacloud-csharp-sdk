// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeQuaraFileDownloadInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the request source. Set the value to sas.
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// The ID of the quarantined file.
        /// 
        /// > If you do not specify this parameter, you cannot call the RollbackSuspEventQuaraFile operation to restore a quarantined file. You can call the [DescribeSuspEventQuaraFiles](~~DescribeSuspEventQuaraFiles~~) operation to query the IDs of quarantined files.
        /// </summary>
        [NameInMap("QuaraFileId")]
        [Validation(Required=false)]
        public int? QuaraFileId { get; set; }

    }

}
