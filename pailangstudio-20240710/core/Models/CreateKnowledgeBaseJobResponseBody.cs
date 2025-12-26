// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class CreateKnowledgeBaseJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>kbjob-9mn******1z54</para>
        /// </summary>
        [NameInMap("KnowledgeBaseJobId")]
        [Validation(Required=false)]
        public string KnowledgeBaseJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>963BD7F9-0C02-5594-9550-BCC6DD43E3C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
