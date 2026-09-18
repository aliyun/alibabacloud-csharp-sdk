// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRayDashboardRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the link is a shared link. If set to true, the token parameter is also required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The token obtained from the GetToken operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>some_token_value</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
