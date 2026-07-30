// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MonthBillSplitGetHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access token.</para>
        /// <list type="bullet">
        /// <item><description><para>This is a required header parameter for HTTP calls. For information about how to obtain the token, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?spm=openapi-amp.newDocPublishment.0.0.5f19281fIKbnyi&docId=3769985">Enterprise access token</a>.</para>
        /// </description></item>
        /// <item><description><para>You can use corp_token=value in the request URL as an alternative.</para>
        /// </description></item>
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
