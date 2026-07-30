// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvUserSaveHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access token.</para>
        /// <list type="bullet">
        /// <item><description>When calling this operation via HTTP, include this as a <b>required parameter</b> in the request URL. For information about how to obtain it, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=3769985">Enterprise access token</a>.</description></item>
        /// <item><description>When appending to the URL, you can use any of the following formats: <c>so_corp_token=value</c>, <c>dtb_corp_token=value</c>, or <c>corp_token=value</c>. <b>Recommended</b>: <c>corp_token=value</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>feth****wls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-so-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripSoCorpToken { get; set; }

    }

}
