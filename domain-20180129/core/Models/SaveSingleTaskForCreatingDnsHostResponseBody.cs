// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveSingleTaskForCreatingDnsHostResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0F1B3547-BE50-4206-8F78-9540FFB85BC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e9b8e8b4-7334-4548-9cec-c30b6891f292</para>
        /// </summary>
        [NameInMap("TaskNo")]
        [Validation(Required=false)]
        public string TaskNo { get; set; }

    }

}
