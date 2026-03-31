// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateYikeWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ProductionId</para>
        /// </summary>
        [NameInMap("ProductionId")]
        [Validation(Required=false)]
        public string ProductionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-zna577pdximvztk5</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
