// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetImageScanNumInPeriodRequest : TeaModel {
        /// <summary>
        /// The number of days.
        /// </summary>
        [NameInMap("PastDay")]
        [Validation(Required=false)]
        public string PastDay { get; set; }

    }

}
