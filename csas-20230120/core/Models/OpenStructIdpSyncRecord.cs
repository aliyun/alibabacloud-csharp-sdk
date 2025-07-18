// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class OpenStructIdpSyncRecord : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("IdpRawJson")]
        [Validation(Required=false)]
        public string IdpRawJson { get; set; }

        [NameInMap("IdpResourceId")]
        [Validation(Required=false)]
        public string IdpResourceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        [NameInMap("SaseRawJson")]
        [Validation(Required=false)]
        public string SaseRawJson { get; set; }

        [NameInMap("SaseResourceId")]
        [Validation(Required=false)]
        public string SaseResourceId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SyncRecordId")]
        [Validation(Required=false)]
        public string SyncRecordId { get; set; }

        [NameInMap("SyncTaskId")]
        [Validation(Required=false)]
        public string SyncTaskId { get; set; }

        [NameInMap("TimeUnix")]
        [Validation(Required=false)]
        public string TimeUnix { get; set; }

    }

}
