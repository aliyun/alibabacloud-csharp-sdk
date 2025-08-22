// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class AddSharedAccountsRequest : TeaModel {
        [NameInMap("accountIds")]
        [Validation(Required=false)]
        public List<long?> AccountIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RegistryModule</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
