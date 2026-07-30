// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCorpDetailInfoHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access token.</para>
        /// <list type="bullet">
        /// <item><description><para>When calling this operation over HTTP, include this as a required parameter in the request URL. For information about how to obtain it, refer to: <a href="https://open.alibtrip.com/#/document/server/corptoken-enterprise-access-credential?handbookId=development-support">Enterprise access token</a>.</para>
        /// </description></item>
        /// <item><description><para>When appending to the URL, use <c>corp_token=value</c> instead.</para>
        /// </description></item>
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
