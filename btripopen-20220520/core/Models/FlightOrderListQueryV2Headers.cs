// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOrderListQueryV2Headers : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The enterprise access credential.</para>
        /// <list type="bullet">
        /// <item><description>When calling this operation over HTTP, this parameter is required and must be appended to the request URL. For information about how to obtain the credential, refer to <a href="https://open.alibtrip.com/#/document/server/corptoken-enterprise-access-credential?handbookId=development-support">Enterprise Access Credential</a>.</description></item>
        /// <item><description>When appending the parameter, use crop_token=value as a replacement.</description></item>
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
