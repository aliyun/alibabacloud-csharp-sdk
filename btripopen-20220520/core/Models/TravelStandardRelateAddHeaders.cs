// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardRelateAddHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feth00jqwls</para>
        /// </summary>
        [NameInMap("x-acs-btrip-corp-token")]
        [Validation(Required=false)]
        public string XAcsBtripCorpToken { get; set; }

    }

}
