// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetOAuthAuthorizationSessionRequest : TeaModel {
        /// <summary>
        /// <para>The authorization session URI.</para>
        /// <remarks>
        /// <para>Returned by the FetchOAuthAuthenticationToken call.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>urn:ietf:params:oauth:request_uri:atpoas_01l6ljnvrpc5niakl3gj3amxxxxxx</para>
        /// </summary>
        [NameInMap("sessionUri")]
        [Validation(Required=false)]
        public string SessionUri { get; set; }

    }

}
