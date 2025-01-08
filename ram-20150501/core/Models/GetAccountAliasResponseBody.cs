// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetAccountAliasResponseBody : TeaModel {
        /// <summary>
        /// <para>The alias of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myalias</para>
        /// </summary>
        [NameInMap("AccountAlias")]
        [Validation(Required=false)]
        public string AccountAlias { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
