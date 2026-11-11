// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentSpecImportFileUrlRequest : TeaModel {
        /// <summary>
        /// <para>The Content-Type of the uploaded file. You must use the same value returned in the response when the client sends a PUT request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/zip</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

    }

}
