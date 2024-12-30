// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetLinkInfoByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the users.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<AccountLinkInfo> Items { get; set; }

    }

}
