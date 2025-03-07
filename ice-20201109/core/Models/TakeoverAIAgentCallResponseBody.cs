// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class TakeoverAIAgentCallResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ARTC channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70f22d5784194938a7e387052f2b3208</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The ID of the human agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uid2</para>
        /// </summary>
        [NameInMap("HumanAgentUserId")]
        [Validation(Required=false)]
        public string HumanAgentUserId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ARTC token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
