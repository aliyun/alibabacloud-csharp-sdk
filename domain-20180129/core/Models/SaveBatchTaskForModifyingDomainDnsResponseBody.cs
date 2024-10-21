// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveBatchTaskForModifyingDomainDnsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6A862A8A-E7AB-4C4E-8946-A74122D9CC4B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35fb2fb7-d4d6-4478-9408-22cb63696b86</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
