// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupCorpTokenHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The application credential, which is one of the header parameters in the HTTP method. <b>Deprecated. Use the</b> <c>app_secret</c> <b>field instead.</b></para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("x-acs-btrip-access-token")]
        [Validation(Required=false)]
        public string XAcsBtripAccessToken { get; set; }

    }

}
