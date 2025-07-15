// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateMixStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the stream mixing task. You can specify this parameter in a request to delete the stream mixing task or query stream mixing tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2a046e-74d7-385e-d2d7-8a5b87e4****</para>
        /// </summary>
        [NameInMap("MixStreamId")]
        [Validation(Required=false)]
        public string MixStreamId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A8CDDFF-0121-4ABB-DA60-AEF095A8W34F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
