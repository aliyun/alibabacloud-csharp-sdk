// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class AssociateSourceServersRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The ID of the migration source. A workgroup can be associated with a maximum of 50 migration sources.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public List<string> SourceId { get; set; }

        /// <summary>
        /// <para>The ID of the workgroup.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-***</para>
        /// </summary>
        [NameInMap("WorkgroupId")]
        [Validation(Required=false)]
        public string WorkgroupId { get; set; }

    }

}
