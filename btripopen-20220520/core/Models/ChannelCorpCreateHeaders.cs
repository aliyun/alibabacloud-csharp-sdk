// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ChannelCorpCreateHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access token.</para>
        /// <list type="bullet">
        /// <item><description>When calling this operation over HTTP, include this as a <b>required parameter</b> in the request URL. For information about how to obtain it, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=3769985">Enterprise access token</a>.</description></item>
        /// <item><description>When appending this parameter, use <c>crop_token=value</c> instead.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aqfr****21</para>
        /// </summary>
        [NameInMap("x-acs-btrip-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripCorpToken { get; set; }

    }

}
