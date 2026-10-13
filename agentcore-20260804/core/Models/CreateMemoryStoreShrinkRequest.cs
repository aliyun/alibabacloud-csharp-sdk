// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateMemoryStoreShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The request to create a memory store.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string BodyShrink { get; set; }

        /// <summary>
        /// <para>The client request token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory-store-create-20260909-001</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
