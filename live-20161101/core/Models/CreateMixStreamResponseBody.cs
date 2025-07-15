// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateMixStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the stream mixing task. You can specify this parameter in a request to delete the stream mixing task or query stream mixing tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2a046e-74d7-385e-253f-8a5b87e4****</para>
        /// </summary>
        [NameInMap("MixStreamId")]
        [Validation(Required=false)]
        public string MixStreamId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D715397-2E66-4AE1-694h-C546628AD145</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
