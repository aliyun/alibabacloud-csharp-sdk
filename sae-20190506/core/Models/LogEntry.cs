// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class LogEntry : TeaModel {
        [NameInMap("instanceID")]
        [Validation(Required=false)]
        public string InstanceID { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("packID")]
        [Validation(Required=false)]
        public string PackID { get; set; }

        [NameInMap("packMeta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

        [NameInMap("versionID")]
        [Validation(Required=false)]
        public string VersionID { get; set; }

    }

}
