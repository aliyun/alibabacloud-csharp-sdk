// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UploadAgentSessionFileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The JSON-RPC correlation identifier for the current request. The Id in the response returns this value as is to correlate the request and response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attachment-rpc-001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC protocol version. The example uses 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The parameter object for the upload stage. The prepare step issues the upload URL, and the complete step confirms that the file has been written to the target session instance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

    }

}
