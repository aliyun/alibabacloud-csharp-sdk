// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IFlightOrderDetailQueryHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access credential.</para>
        /// <list type="bullet">
        /// <item><description><para>When calling this API over HTTP, this parameter is required and must be appended to the request URL. For how to obtain the credential, see <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=3769985">Enterprise Access Credential</a>.</para>
        /// </description></item>
        /// <item><description><para>When appending the parameter, use the format crop_token=value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>feth00jqwls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripCorpToken { get; set; }

    }

}
