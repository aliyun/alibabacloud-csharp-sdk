// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditShowAndReplaceRequest : TeaModel {
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public float? EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public float? StartTime { get; set; }

        [NameInMap("StorageInfo")]
        [Validation(Required=false)]
        public string StorageInfo { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
