// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterBatchDisableMemberApiKeysRequest : TeaModel {
        /// <summary>
        /// <para>The list of member user IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

    }

}
