// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateAIAgentCallResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>877ae632caae49b1afc81c2e8194ffb4</para>
        /// </summary>
        [NameInMap("AIAgentUserId")]
        [Validation(Required=false)]
        public string AIAgentUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>70f22d5784194938a7e387052f2b3208</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
