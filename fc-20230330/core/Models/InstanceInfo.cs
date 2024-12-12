// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InstanceInfo : TeaModel {
        [NameInMap("createdTimeMs")]
        [Validation(Required=false)]
        public long? CreatedTimeMs { get; set; }

        [NameInMap("destroyedTimeMs")]
        [Validation(Required=false)]
        public long? DestroyedTimeMs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1ef6b6ff-7f7b-485e-ab49-501ac681****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
