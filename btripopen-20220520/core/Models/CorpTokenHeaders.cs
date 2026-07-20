// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CorpTokenHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vf9_bvla0qs</para>
        /// </summary>
        [NameInMap("x-acs-btrip-access-token")]
        [Validation(Required=false)]
        public string XAcsBtripAccessToken { get; set; }

    }

}
