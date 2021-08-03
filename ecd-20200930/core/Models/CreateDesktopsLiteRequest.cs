// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDesktopsLiteRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        [NameInMap("UserAssignMode")]
        [Validation(Required=false)]
        public string UserAssignMode { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("EnableInternetAccess")]
        [Validation(Required=false)]
        public bool? EnableInternetAccess { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

    }

}
