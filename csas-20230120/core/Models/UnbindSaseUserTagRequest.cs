// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UnbindSaseUserTagRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the users.</para>
        /// </summary>
        [NameInMap("SaseUserIds")]
        [Validation(Required=false)]
        public List<string> SaseUserIds { get; set; }

        /// <summary>
        /// <para>The IDs of the user tags.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
