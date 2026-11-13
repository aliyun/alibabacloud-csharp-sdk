// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelGroupRequest : TeaModel {
        /// <summary>
        /// <para>The description. This field can be null and contains up to 1,024 UTF-16 code units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Model group for business integration</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The group version obtained from the most recent Get operation. A stale version returns Conflict.ModelGroupChanged. Submitting the same expectedVersion, name, description, and modelCardIds as-is retries the Failed or PartiallyFailed configuration of the same version, reuses the operationId, and does not increment the group version. Pending, Running, or Succeeded states are not forcibly reset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The actual or logical model identities within the same instance. This field can be null and must not contain duplicates. Model groups are not accepted as members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modelCardIds")]
        [Validation(Required=false)]
        public List<string> ModelCardIds { get; set; }

        /// <summary>
        /// <para>The unique name within the instance. The length is 1 to 128 UTF-8 bytes after trimming.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-model-group</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
