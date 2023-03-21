// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateUniRestorePlanRequest : TeaModel {
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("InstanceUuid")]
        [Validation(Required=false)]
        public string InstanceUuid { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        [NameInMap("ResetScn")]
        [Validation(Required=false)]
        public string ResetScn { get; set; }

        [NameInMap("ResetTime")]
        [Validation(Required=false)]
        public string ResetTime { get; set; }

        [NameInMap("RestoreInfo")]
        [Validation(Required=false)]
        public string RestoreInfo { get; set; }

        [NameInMap("TimePoint")]
        [Validation(Required=false)]
        public long? TimePoint { get; set; }

    }

}
