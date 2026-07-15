// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetDashboardRequest : TeaModel {
        /// <summary>
        /// <para>Indicates whether this is a shared link. If it is, the \<c>token\\</c> parameter is also required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The token obtained from GetToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>some_token_value</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
