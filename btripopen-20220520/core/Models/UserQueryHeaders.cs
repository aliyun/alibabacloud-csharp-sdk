// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UserQueryHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access token.</para>
        /// <list type="bullet">
        /// <item><description>When calling over HTTP, this is a <b>required parameter</b> that must be included in the request URL. For information about how to obtain it, refer to: <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=3769985">Enterprise access token</a>.</description></item>
        /// <item><description>When appending it to the URL, you can use <c>corp_token=value</c> as a replacement.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fet****wls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-so-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripSoCorpToken { get; set; }

    }

}
