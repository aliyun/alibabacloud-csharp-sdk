// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AllBaseCityInfoQueryHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The header parameter obtained from the &quot;Application Access Credential&quot; operation. Add it to the header. In HTTP mode, you can use access_token=value in the URL as an alternative.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feth00jqwls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-access-token")]
        [Validation(Required=false)]
        public string XAcsBtripAccessToken { get; set; }

    }

}
