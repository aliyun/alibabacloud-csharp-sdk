// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetAgentSpecImportFileUrlRequest : TeaModel {
        /// <summary>
        /// <para>The Content-Type of the uploaded file. The client must use the same value in the PUT request as the one returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/zip</para>
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

    }

}
