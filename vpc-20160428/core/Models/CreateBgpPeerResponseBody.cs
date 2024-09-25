// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateBgpPeerResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the BGP peer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bgp-m5eoyp2mwegk8ce9v****</para>
        /// </summary>
        [NameInMap("BgpPeerId")]
        [Validation(Required=false)]
        public string BgpPeerId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D4B7649A-61BB-4C64-A586-1DFF1EDA6A42</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
