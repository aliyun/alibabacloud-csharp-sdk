// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class InvokeCommandRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        [NameInMap("RepeatMode")]
        [Validation(Required=false)]
        public string RepeatMode { get; set; }

        [NameInMap("Timed")]
        [Validation(Required=false)]
        public bool? Timed { get; set; }

        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("WindowsPasswordName")]
        [Validation(Required=false)]
        public string WindowsPasswordName { get; set; }

    }

}
