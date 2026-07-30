// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderQueryHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access credential.</para>
        /// <list type="bullet">
        /// <item><description><para>When calling this API over HTTP, this parameter must be included as a required parameter in the request URL. For information about how to obtain the credential, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.2a70281fjlmVlc&docId=3769985">Enterprise access credential</a>.</para>
        /// </description></item>
        /// <item><description><para>When appending this parameter, use so_corp_token=value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>feth00jqwls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-so-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripSoCorpToken { get; set; }

    }

}
