// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateApplicationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1332695887xxxxxx</para>
        /// </summary>
        [NameInMap("ownerAccountId")]
        [Validation(Required=false)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66c0c9fffeb86b450c199fcd</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
