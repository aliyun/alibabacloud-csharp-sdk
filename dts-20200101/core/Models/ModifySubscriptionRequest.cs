// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifySubscriptionRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("SubscriptionDataTypeDDL")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDDL { get; set; }

        [NameInMap("SubscriptionDataTypeDML")]
        [Validation(Required=false)]
        public bool? SubscriptionDataTypeDML { get; set; }

    }

}
