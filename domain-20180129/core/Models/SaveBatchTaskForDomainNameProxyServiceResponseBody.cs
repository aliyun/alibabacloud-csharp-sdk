// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForDomainNameProxyServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F51977F9-2B40-462B-BCCD-CF5BB1E9DB56</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d3babb0a-c939-4c25-8c65-c47b65f54923</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
