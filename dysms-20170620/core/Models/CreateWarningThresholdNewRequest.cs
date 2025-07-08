// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class CreateWarningThresholdNewRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("DailyHaltLimit")]
        [Validation(Required=false)]
        public int? DailyHaltLimit { get; set; }

        [NameInMap("DailyWarningLimit")]
        [Validation(Required=false)]
        public int? DailyWarningLimit { get; set; }

        [NameInMap("MonthlyHaltLimit")]
        [Validation(Required=false)]
        public int? MonthlyHaltLimit { get; set; }

        [NameInMap("MonthlyWarningLimit")]
        [Validation(Required=false)]
        public int? MonthlyWarningLimit { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
