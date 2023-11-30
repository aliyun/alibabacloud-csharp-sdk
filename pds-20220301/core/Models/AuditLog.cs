// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AuditLog : TeaModel {
        [NameInMap("acted_at")]
        [Validation(Required=false)]
        public string ActedAt { get; set; }

        [NameInMap("action_category")]
        [Validation(Required=false)]
        public string ActionCategory { get; set; }

        [NameInMap("action_type")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("actor_id")]
        [Validation(Required=false)]
        public string ActorId { get; set; }

        [NameInMap("actor_name")]
        [Validation(Required=false)]
        public string ActorName { get; set; }

        [NameInMap("actor_type")]
        [Validation(Required=false)]
        public string ActorType { get; set; }

        [NameInMap("client_device")]
        [Validation(Required=false)]
        public string ClientDevice { get; set; }

        [NameInMap("client_ip")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("client_type")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        [NameInMap("client_version")]
        [Validation(Required=false)]
        public string ClientVersion { get; set; }

        [NameInMap("detail")]
        [Validation(Required=false)]
        public AuditLogDetail Detail { get; set; }

        [NameInMap("file_path_type")]
        [Validation(Required=false)]
        public string FilePathType { get; set; }

        [NameInMap("log_id")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        [NameInMap("object_id")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        [NameInMap("object_name")]
        [Validation(Required=false)]
        public string ObjectName { get; set; }

    }

}
