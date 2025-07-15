// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DeleteMixStreamResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the stream mixing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>749b7594-86d6-37b1-513b-e1e19845****</para>
        /// </summary>
        [NameInMap("MixStreamId")]
        [Validation(Required=false)]
        public string MixStreamId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE9407FF-F897-4DBD-338D-98A750AD805F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
