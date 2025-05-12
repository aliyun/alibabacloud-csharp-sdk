// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Connection : TeaModel {
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        [NameInMap("ConnectionId")]
        [Validation(Required=false)]
        public string ConnectionId { get; set; }

        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<ConnectionModels> Models { get; set; }
        public class ConnectionModels : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

        }

        [NameInMap("ResourceMeta")]
        [Validation(Required=false)]
        public ConnectionResourceMeta ResourceMeta { get; set; }
        public class ConnectionResourceMeta : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
